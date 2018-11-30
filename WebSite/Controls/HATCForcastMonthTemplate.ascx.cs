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


public partial class Controls_HATCForcastMonthTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    class MQtyOrder
    {
        public int OrderQty { get; set; }
        public string OrderDate { get; set; }
        public int startPosition { get; set; }
        public int endPosition { get; set; }
        public int LineDate { get; set; }
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
    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("HATC_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        //string CustCode = "40108011";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            
            using (StreamReader sr = new StreamReader(filename))
            {
                List<MyCompany.Data.Objects.HATCForcastMonthImport> HATCList = new List<MyCompany.Data.Objects.HATCForcastMonthImport>();
                string line = string.Empty, CustMatNo = string.Empty, year = string.Empty, PlantCode = string.Empty;
                Dictionary<int, string> dueDate = new Dictionary<int, string>();
                Dictionary<int, double> orderQty = new Dictionary<int, double>();
                using (SqlProcedure sp = new SqlProcedure("sp_HATC_ForcastMonth_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.EndsWith("MONTH") && line.StartsWith(""))
                    {
                        dueDate.Clear();
                        // Correct DueDate
                        string[] _data = line.Substring(line.IndexOf("PLAN GROUP") + 10, line.IndexOf("MONTH") - line.IndexOf("PLAN GROUP") - 10).Trim().Split(' ');
                        int dataIndex = 0;
                        for (int i = 0; i < _data.Length; i++)
                        {
                            if (!String.IsNullOrEmpty(_data[i]))
                            {
                                dueDate.Add(dataIndex, _data[i]);
                                dataIndex++;
                            }
                        }
                    }

                    int lineNum = 0;
                    if (Int32.TryParse(line.Substring(0,6).Trim(),out lineNum))
                    {
                        if (!(line.Trim().EndsWith("ROKI(THAILAND)CO.,LTD.") || line.Trim().StartsWith("TOTAL") || String.IsNullOrEmpty(line.Substring(0,50).Trim())))
                        {
                            CustMatNo = line.Substring(6, 35).Trim();
                            PlantCode = line.Substring(41, 15).Trim();
                            string[] _qty  = line.Substring(57, line.Length - 57).Trim().Split(' ');
                            int dataIndex = 0;
                            orderQty.Clear();
                            for (int i = 0; i < _qty.Length; i++)
                            {
                                if (!String.IsNullOrEmpty(_qty[i]))
                                {
                                    orderQty.Add(dataIndex, Convert.ToDouble(_qty[i]));
                                    dataIndex++;
                                }
                            }

                            // Insert Data
                            foreach (KeyValuePair<int,string> item in dueDate)
                            {
                                MyCompany.Data.Objects.HATCForcastMonthImport Order = new MyCompany.Data.Objects.HATCForcastMonthImport();

                                Order.OrderBy = PlantCode.EndsWith("03") ? "40138011" : "40108011";
                                Order.DeliveryDestination = "";
                                Order.CustomerMatCode = CustMatNo;
                                Order.PartsDevision = "1";
                                Order.CustomerPO = "";
                                Order.ReliabilityDevision = "F";
                                Order.Unit = "ST";
                                Order.PlngPeriod = "M";
                                Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                string[] _dueDate = item.Value.Split('/');
                                Order.DeliveryDate = Convert.ToDateTime(String.Format("{0}-{1}-{2}", _dueDate[1],string.Format("{0:00}", Convert.ToInt32( _dueDate[0])), "01"));
                                Order.Quantity = Convert.ToDecimal(orderQty[item.Key]);
                                Order.Insert();
                            }
                        }
                    }
                }
                sr.Close();
            }
        }


    }
}
