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



public partial class Controls_IMCTForcastTemplate : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("HATC_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_IMCT_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    string DeliveryDestination = line.Substring(33, 6).Trim();
                    string OrderBy = "40111011";
                    string CusMatCode = line.Substring(41, 10);
                    string locCode = line.Substring(39, 2).Trim();
                    string[] materialTemp = SharedBusinessRules.getMaterial(CusMatCode, OrderBy, DeliveryDestination, "IMCT").Split(':');

                    int startPointDate = 92;
                    int startPointQty = 148;
                    for (int w = 1; w <= 6; w++)
                    {
                        DateTime dateOld = Convert.ToDateTime(line.Substring(startPointDate, 4).ToString() + "-" + line.Substring(startPointDate + 4, 2).ToString() + "-" + line.Substring(startPointDate + 6, 2).ToString());
                        int subPointDate = 8;
                        int subPointQty = 0;
                        for (int d = 1; d <= 6; d++)
                        {
                            DateTime dateDrliveryDate;
                            if (line.Substring(startPointDate + subPointDate, 4).ToString().Trim() != string.Empty)
                            {
                                dateDrliveryDate = Convert.ToDateTime(line.Substring(startPointDate + subPointDate, 4).ToString() + "-" + line.Substring(startPointDate + subPointDate + 4, 2).ToString() + "-" + line.Substring(startPointDate + subPointDate + 6, 2).ToString());
                            }
                            else
                            {
                                dateDrliveryDate = dateOld.AddDays(d - 1);
                            }
                            int numQty = Convert.ToInt32(line.Substring(startPointQty + subPointQty, 6).ToString());
                            MyCompany.Models.IMCTForcastImport forcast = new MyCompany.Models.IMCTForcastImport();
                            forcast.OrderBy = OrderBy;
                            forcast.DeliveryDestination = DeliveryDestination + "-" + locCode;
                            forcast.CustomerMatCode = CusMatCode;
                            if (materialTemp.Length > 1)
                            {
                                forcast.SAPCode = materialTemp[0];
                                forcast.PartsDevision = materialTemp[1];
                                forcast.DeliveryDestinationCode = materialTemp[2];
                                forcast.Key1 = materialTemp[3];
                                forcast.Key2 = materialTemp[4];
                                forcast.Key3 = materialTemp[5];
                            }                            
                            forcast.CustomerPO = "";
                            forcast.ReliabilityDevision = "F";
                            forcast.Unit = "ST";
                            forcast.PlngPeriod = "D";
                            forcast.DeliveryDate = dateDrliveryDate;
                            forcast.Quantity = numQty;
                            forcast.FileName = fn;
                            forcast.Insert();
                            subPointDate += 8;
                            subPointQty += 6;
                        }
                        startPointDate += 100;
                        startPointQty += 100;
                    }

                }
            }


        }
    }
}
