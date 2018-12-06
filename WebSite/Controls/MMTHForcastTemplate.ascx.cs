using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using MyCompany.Data;
using MyCompany.Rules;



public partial class Controls_MMTHForcastTemplate : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("MMTH_{0}_FORVAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_MMTH_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    
                    string[] arr = line.Split('|');
                    if (!arr[4].Contains("9999999999999999"))
                    {
                        string plantCode = arr[2];
                        string yyyy = arr[3].Substring(0, 4);
                        string MM = arr[3].Substring(4, 2);
                        string partNo = arr[4];
                        string dayOld = arr[11];
                        for (int d = 12; d <= arr.Length - 1; d += 2)
                        {
                            if (arr[d -1] == "00")
                            {
                                break;
                            }
                            if (Convert.ToInt32(dayOld) > Convert.ToInt32(arr[d - 1]))
                            {
                                DateTime dtTemp = Convert.ToDateTime(yyyy + "-" + MM + "-01");
                                dtTemp = dtTemp.AddMonths(1);
                                MM = dtTemp.Month.ToString();
                                yyyy = dtTemp.Year.ToString();
                            }
                            MyCompany.Models.MMTHForcastImport forcast = new MyCompany.Models.MMTHForcastImport();                                              
                            forcast.OrderBy = "40113011";
                            forcast.DeliveryDestination = plantCode;
                            forcast.CustomerMatCode = partNo.Trim();
                            string[] materialTemp = SharedBusinessRules.getMaterial(forcast.CustomerMatCode, "40113011", plantCode, "MMTh").Split(':');
                            if (materialTemp.Length > 1)
                            {
                                forcast.SAPCode = materialTemp[0];
                                forcast.PartsDevision = materialTemp[1];
                                forcast.DeliveryDestinationCode = materialTemp[2];
                            }                            
                            forcast.CustomerPO = "";
                            forcast.ReliabilityDevision = "F";
                            forcast.Unit = "ST";
                            forcast.PlngPeriod = "D";
                            forcast.DeliveryDate = Convert.ToDateTime(yyyy + "-" + MM + "-" + arr[d-1]);
                            forcast.Quantity = Convert.ToInt32(arr[d]);
                            forcast.Insert();
                            dayOld = arr[d - 1];
                        
                        }
                    }
                }
            }
        }
    }
}
