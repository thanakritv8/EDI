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



public partial class Controls_TYMForcastTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("TYM_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40103010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_TYM_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        MyCompany.Data.Objects.TYMForcastImport Order = new MyCompany.Data.Objects.TYMForcastImport();
                        Order.OrderBy = CustCode;
                        Order.DeliveryDestination = "";
                        Order.CustomerMatCode = line.Substring(0, 3) + "-" + line.Substring(3, 5) + "-" + line.Substring(8, 2) + "-" + line.Substring(10, 2) + "-" + line.Substring(12, 2) + "-" + line.Substring(14, 4) + "-" + line.Substring(18, 4);//line.Substring(0, 22);
                        Order.PartsDevision = "1";
                        Order.CustomerPO = "";
                        Order.ReliabilityDevision = "P";
                        Order.DeliveryDate = Convert.ToDateTime(line.Substring(22, 4).Trim() + "-" + line.Substring(26, 2).Trim() + "-" + line.Substring(28, 2).Trim());
                        Order.Quantity = float.Parse(line.Substring(30, 8)).ToString().Trim();
                        Order.Unit = "ST";
                        Order.PlngPeriod = "D";
                        Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                        Order.Insert();
                    }
                }
                sr.Close();
            }
        }
        
    }
}