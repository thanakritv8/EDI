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


public partial class Controls_IMCTOrderTemplate : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("IMCT_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40111011";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                //using (SqlProcedure sp = new SqlProcedure("sp_IMCT_Order_ClearData"))
                //{
                //    sp.ExecuteNonQuery();
                //}
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        if (!line.Contains("ISUZU"))
                        {
                            MyCompany.Models.IMCTOrderImport Order = new MyCompany.Models.IMCTOrderImport();
                            Order.OrderBy = CustCode;
                            Order.DeliveryDestination = line.Substring(120, 5).Trim();
                            Order.CustomerMatCode = line.Substring(35, 10).Trim();
                            Order.CustomerPO = line.Substring(2, 10).Trim();
                            Order.ReliabilityDevision = "P";
                            Order.DeliveryDate = Convert.ToDateTime(line.Substring(50, 4).Trim() + "-" + line.Substring(54, 2).Trim() + "-" + line.Substring(56, 2).Trim());
                            Order.Quantity = float.Parse(line.Substring(58, 6)).ToString().Trim();
                            Order.Unit = "ST";
                            Order.PlngPeriod = "D";
                            string[] materialTemp = SharedBusinessRules.getMaterial(line.Substring(35, 10).Trim().Replace(" ", ""), CustCode, line.Substring(120, 5).Trim(), "IMCT").Split(':');
                            if (materialTemp.Length > 1)
                            {
                                Order.SAPCode = materialTemp[0];
                                Order.PartsDevision = materialTemp[1];
                                Order.DeliveryDestinationCode = materialTemp[2];
                                Order.Key1 = materialTemp[3];
                                Order.Key2 = materialTemp[4];
                                Order.Key3 = materialTemp[5];
                            }
                            Order.AddCode = i.ToString();
                            Order.PlantCode = "";
                            Order.Arrivaltime = line.Substring(159, 2).Trim() + ":" + line.Substring(161, 2).Trim();
                            Order.FromTo = "RTP:" + line.Substring(120, 5).Trim();
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