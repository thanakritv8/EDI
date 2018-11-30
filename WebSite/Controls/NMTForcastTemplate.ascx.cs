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



public partial class Controls_NMTForcastTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("NMT_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40118010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                int totalLine = 0;
                Dictionary<int, string> DueDate = new Dictionary<int, string>();
                using (SqlProcedure sp = new SqlProcedure("sp_NMT_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        string[] data = line.Split(',');
                        if (data.Length > 0 && totalLine == 0)
                        {
                            #region DeliveryDate

                            for (int i = 11; i < data.Length; i++)
                            {
                                if (data[i].StartsWith("Daily Qty(N+"))
                                {
                                    //Daily Qty(N+1 month 26th)
                                    // get N Month
                                    //string[] montData = data[i].Split('+');
                                    //string DeliveryDate = String.Format("{0}-{1}-", data[236].ToString().Trim() , String.Format("{0:00}"
                                    //    , Convert.ToInt32( data[237].ToString().Trim()) + Convert.ToInt32(data[1].Substring(0,1))));

                                    if (!DueDate.ContainsKey(i))
                                    {
                                        DueDate.Add(i, data[i]);
                                    }
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            // RowData
                            //DeliveryDate + string.Format("{0:00}", montData[1].Substring(7,montData[1].Length-1).Replace("th","").Replace("st","").Replace("nd","").Replace("rd",""))
                            if (!String.IsNullOrEmpty(data[236].Trim()))
                            {
                                foreach (KeyValuePair<int, string> item in DueDate)
                                {
                                    int Qty = 0;
                                    Int32.TryParse(data[item.Key], out Qty);

                                    string[] _dueDate = item.Value.Trim().Split('+');
                                    //Daily Qty(N+2 month 18th)
                                    int _month = Convert.ToInt32(data[237]) + Convert.ToInt32(_dueDate[1].Substring(0, 1));
                                    int _year = Convert.ToInt32(data[236]);
                                    if (_month > 12)
                                    {
                                        _year += Convert.ToInt32(_month / 12);
                                        _month = _month % 12;
                                    }
                                    //Check Day
                                    int _day = Convert.ToInt32(_dueDate[1].Substring(8, 4).Trim().Replace("th", "").Replace("st", "").Replace("nd", "").Replace("rd", "").Replace(")", ""));
                                    int lastDayOfMonth = DateTime.DaysInMonth(_year, _month);
                                    if(_day <= lastDayOfMonth)
                                    {
                                        string DeliveryDate = string.Format("{0}-{1}-{2}"
                                            , _year
                                            , String.Format("{0:00}", _month)
                                            , String.Format("{0:00}", _day)
                                        );
                                        //DeliveryDate + string.Format("{0:00}", montData[1].Substring(7,montData[1].Length-1).Replace("th","").Replace("st","").Replace("nd","").Replace("rd",""))
                                        MyCompany.Data.Objects.NMTForcastImport Order = new MyCompany.Data.Objects.NMTForcastImport();
                                        Order.OrderBy = CustCode;
                                        Order.DeliveryDestination = data[10].ToString().Trim();
                                        Order.CustomerMatCode = data[4].Trim();
                                        Order.PartsDevision = "1";
                                        Order.CustomerPO = "";
                                        Order.ReliabilityDevision = "P";
                                        Order.DeliveryDate = Convert.ToDateTime(DeliveryDate);
                                        Order.Quantity = Qty.ToString().Trim();
                                        Order.Unit = "ST";
                                        Order.PlngPeriod = "D";
                                        Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                        Order.Insert();
                                    }
                                }
                            }
                        }
                    }

                    totalLine++;
                }
                sr.Close();
            }
        }
    }
}
