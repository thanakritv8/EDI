using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Text;
using MyCompany.Data;
using MyCompany.Rules;


public partial class Controls_HATCForcastTemplate : System.Web.UI.UserControl
{
    class MQtyOrder
    {
        public int OrderQty { get; set; }
        public string OrderDate { get; set; }
        public int startPosition { get; set; }
        public int endPosition { get; set; }
        public int LineDate { get; set; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public int SetNumber(string n)
    {
        int nVal = 0;
        int number;
        if (int.TryParse(n, out nVal))
        {
            if (nVal < 0)
                number = Math.Abs(nVal);
            else
                number = nVal;
        }
        else
        {
            number = 0;
        }
        return number;
    }
    #region ForcastMonth

    #endregion

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("HATC_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);
        string LocationCode = string.Empty;
        // HATC Order
        string CustCode = string.Empty;
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                //List<MyCompany.Models.HATCForcastImport> HATCList = new List<MyCompany.Models.HATCForcastImport>();
                string CustMatNo = string.Empty, year = string.Empty, PlantCode = string.Empty;
                Dictionary<int, string> dueDate = new Dictionary<int, string>();
                Dictionary<int, double> orderQty = new Dictionary<int, double>();
                int lineIndex = -1;
                using (SqlProcedure sp = new SqlProcedure("sp_HATC_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                string ReliabilityDevision = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (lineIndex >= 0)
                    {
                        lineIndex++;
                    }

                    switch (lineIndex)
                    {
                        case 3:
                            year = line.Substring(40, 4);
                            string[] ln = line.Split(' ');
                            LocationCode = ln[3];
                            break;
                        case 5:
                            try
                            {
                                dueDate.Clear();
                                orderQty.Clear();
                                // get Part and Delivery Date
                                CustMatNo = line.Substring(0, line.IndexOf("DATE")).Trim();
                                string[] data = line.Substring(line.IndexOf("DATE") + 4, (line.IndexOf("TOTAL") - line.IndexOf("DATE") - 4)).Trim().Split(' ');
                                int colIndex = 0;
                                for (int i = 0; i < data.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(data[i].Trim()))
                                    {
                                        string[] _dueDate = data[i].Split('/');
                                        if (_dueDate.Length > 0)
                                        {
                                            dueDate.Add(colIndex, String.Format("{0}-{1}-{2}", year, _dueDate[1], _dueDate[0]));
                                            colIndex++;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                            break;
                        case 6: try
                            {

                                line = line.Substring(line.IndexOf("QTY.") + 4, line.Length - line.IndexOf("QTY.") - 10);
                                int colIndex = 0;
                                while (line.Length >= 7)
                                {
                                    string qty = line.Substring(0, 7).Trim();
                                    qty = String.IsNullOrEmpty(qty) ? "0" : qty;
                                    orderQty.Add(colIndex, Convert.ToDouble(qty));
                                    line = line.Substring(7, line.Length - 7);
                                    colIndex++;
                                }

                            }
                            catch (Exception ex)
                            {
                            }
                            break;                        
                        case 11:
                            PlantCode = line.Substring(16, 17).Trim();

                            for (int i = 0; i < dueDate.Count; i++)
                            {
                                //[XXXX]03 => 40138011 => HATC-P
                                //[XXXX]xx => 40108011 => HATC

                                MyCompany.Models.HATCForcastImport forcast = new MyCompany.Models.HATCForcastImport();
                                forcast.OrderBy = PlantCode.EndsWith("03") ? "40138011" : "40108011";
                                forcast.DeliveryDestination = PlantCode + "-" + LocationCode;
                                forcast.CustomerMatCode = CustMatNo;
                                string[] materialTemp = SharedBusinessRules.getMaterial(forcast.CustomerMatCode, PlantCode.EndsWith("03") ? "40138011" : "40108011", PlantCode, LocationCode).Split(':');
                                if (materialTemp.Length > 1)
                                {
                                    forcast.SAPCode = materialTemp[0];
                                    if (materialTemp[1] == "1A")
                                    {
                                        forcast.PartsDevision = "1";
                                    }
                                    else if (materialTemp[1] == "1B")
                                    {
                                        forcast.PartsDevision = "2";
                                    }
                                    else
                                    {
                                        forcast.PartsDevision = materialTemp[1];
                                    }
                                    
                                    forcast.DeliveryDestinationCode = materialTemp[2];
                                    forcast.Key1 = materialTemp[3];
                                    forcast.Key2 = materialTemp[4];
                                    forcast.Key3 = materialTemp[5];
                                }
                                forcast.CustomerPO = "";
                                forcast.ReliabilityDevision = ReliabilityDevision;
                                forcast.Unit = "ST";
                                forcast.PlngPeriod = "D";
                                forcast.DeliveryDate = Convert.ToDateTime(dueDate[i]);
                                forcast.Quantity = Convert.ToInt32(orderQty[i].ToString());
                                forcast.FileName = fn;
                                forcast.Insert();
                            }
                            break;
                        default:
                            break;
                    }

                    if (line.Trim().StartsWith("PART ORDER SCHEDULE (MAIL)") || line.Trim().StartsWith("PURCHASE SHEET (MAIL)"))
                    {
                        if (line.Trim().StartsWith("PART ORDER SCHEDULE (MAIL)"))
                        {
                            ReliabilityDevision = "F";
                        }
                        else if (line.Trim().StartsWith("PURCHASE SHEET (MAIL)"))
                        {
                            ReliabilityDevision = "P";
                        }
                        lineIndex = 0;
                    }



                }
                
                sr.Close();

            }
        }


    }
}
