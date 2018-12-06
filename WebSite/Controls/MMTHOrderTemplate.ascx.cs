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




public partial class Controls_MMTHOrderTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("MMTH_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40113011";
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
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
            
                        if (line.Contains("T099") && !line.Contains("9999999999"))
                        {

                            string[] item = line.Split(Convert.ToChar("|"));
                            MyCompany.Models.MMTHOrderImport Order = new MyCompany.Models.MMTHOrderImport();
                            Order.OrderBy = CustCode;
                            Order.DeliveryDestination = item[2]; 
                            Order.CustomerMatCode = item[7].Trim();
                            string[] materialTemp = SharedBusinessRules.getMaterial(item[7].Trim(), CustCode, item[2], "MMTh").Split(':');
                            if (materialTemp.Length > 1)
                            {
                                Order.SAPCode = materialTemp[0];
                                Order.PartsDevision = materialTemp[1];
                                Order.DeliveryDestinationCode = materialTemp[2];
                                Order.Key1 = materialTemp[3];
                                Order.Key2 = materialTemp[4];
                                Order.Key3 = materialTemp[5];
                            }                            
                            Order.CustomerPO = item[4].Trim();
                            Order.ReliabilityDevision = "P";
                            Order.DeliveryDate =Convert.ToDateTime( item[5].Substring(0, 4).Trim() + "-" + item[5].Substring(5, 2).Trim() + "-" + item[5].Substring(8, 2).Trim());
                            Order.Quantity = float.Parse(item[8]).ToString().Trim();
                            Order.Unit = "ST";
                            Order.PlngPeriod = "D";
                            Order.AddCode = item[3] + ":" + item[6] + ":" + item[11] + ": :" + item[26] + ":" + i.ToString();
                            Order.PlantCode = item[10];
                            Order.Arrivaltime = "00:00:00";
                            Order.FromTo = item[1] + ":PLANT-" + item[2];
                            Order.Filename = fn;
                            Order.Insert();
                            i++;                   
                        }
                    }
                }
                sr.Close();
            }

        }
    }
}