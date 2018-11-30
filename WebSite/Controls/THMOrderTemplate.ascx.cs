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




public partial class Controls_THMOrderTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("THM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        
        string CustCode = "40101010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_THM_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        //string shipto = line.Substring(145, 5) + "-" + line.Substring(22, 6);
                        if ((line.Substring(140, 5) == "45320" || line.Substring(140, 5) == "05386") && line.Substring(10, 12) != "000000000000")
                        //if ((line.Substring(140, 5).Trim() == "CRS1" || line.Substring(140, 5) == "45320") && line.Substring(10, 12) != "000000000000")
                        {
                            //string[] item = line.Split(Convert.ToChar("|"));
                            MyCompany.Data.Objects.THMOrderImport Order = new MyCompany.Data.Objects.THMOrderImport();
                            Order.OrderBy = CustCode;
                            Order.DeliveryDestination = ""; //Not sure
                            Order.CustomerMatCode = line.Substring(28, 18).Replace(" ","");
                            Order.PartsDevision = "1";
                            Order.CustomerPO = line.Substring(10, 12);
                            Order.ReliabilityDevision = "P";
                            Order.DeliveryDate =Convert.ToDateTime( line.Substring(118, 4) + "-" + line.Substring(122, 2) + "-" + line.Substring(124, 2));
                            Order.Quantity = float.Parse(line.Substring(126, 7)).ToString().Trim();
                            Order.Unit = "ST";
                            Order.PlngPeriod = "D";
                            Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                            Order.Insert();                                               
                            
                        }

                    }
                }
                sr.Close();
            }

        }

        
    }
}