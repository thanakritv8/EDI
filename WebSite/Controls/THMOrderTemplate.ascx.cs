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
        string fn = filename;
        filename = String.Format("THM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = string.Empty; // "40108011";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                int totalLine = 0, totalOrder = 1;

                using (SqlProcedure sp = new SqlProcedure("sp_THM_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }

                while ((line = sr.ReadLine()) != null)
                {
                    totalLine++;
                    if (line.Length > 0)
                    {
                        #region Format
                        // "000000000000" is Supply Part
                        string shipto = line.Substring(145, 5) + "-" + line.Substring(22, 6);
                        if ((line.Substring(140, 5) == "45320" || line.Substring(140, 5) == "05386") && line.Substring(10, 12) != "000000000000")
                        {
                            MyCompany.Models.THMOrderImport Order = new MyCompany.Models.THMOrderImport();
                            Order.DeliveryDestination = line.Substring(145, 5) + "-" + line.Substring(22, 6);
                            Order.OrderBy = "40101011";
                            Order.CustomerMatCode = line.Substring(28, 18).Trim().Replace(" ", "");
                            string[] materialTemp = SharedBusinessRules.getMaterial(line.Substring(28, 18).Trim().Replace(" ", ""), Order.OrderBy, line.Substring(22, 6), line.Substring(145, 5)).Split(':');
                            if (materialTemp.Length > 1)
                            {
                                Order.SAPCode = materialTemp[0];
                                Order.PartsDevision = materialTemp[1];
                                Order.DeliveryDestinationCode = materialTemp[2];
                                Order.Key1 = materialTemp[3];
                                Order.Key2 = materialTemp[4];
                                Order.Key3 = materialTemp[5];
                            }
                            Order.CustomerPO = line.Substring(10, 12).Trim();
                            Order.ReliabilityDevision = "P"; //Realiability = [Forcast=F,Order=P]
                            Order.DeliveryDate = Convert.ToDateTime(line.Substring(118, 4).Trim() + "-" + line.Substring(122, 2).Trim() + "-" + line.Substring(124, 2).Trim());
                            Order.Quantity = line.Substring(126, 7).Trim();
                            Order.Unit = "ST"; // SD Fixd Data Unit = ST
                            //SD Fixd Data Unit = ST, Periad = D, Realiability = [Forcast=F,Order=P]
                            Order.PlngPeriod = "D"; // Periad = D
                            Order.PlantCode = line.Substring(22, 6) + " Add. " + line.Substring(94, 4).Trim();
                            Order.AddCode = totalOrder.ToString();
                            Order.Arrivaltime = line.Substring(116, 2) + ":00:00";
                            Order.FromTo = line.Substring(88, 5).Trim() + ":" + line.Substring(145, 5);
                            Order.Filename = fn;
                            Order.Insert();
                            totalOrder++;
                        }
                        #endregion
                    }
                }

                sr.Close();
            }

        }
        //// Save file
        //string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        //filename = String.Format("THM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        //AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        
        //string CustCode = "40101010";
        //filename = Server.MapPath("~/Files/") + filename;
        //if (File.Exists(filename))
        //{
        //    string line = string.Empty;
        //    using (StreamReader sr = new StreamReader(filename))
        //    {
        //        using (SqlProcedure sp = new SqlProcedure("sp_THM_Order_ClearData"))
        //        {
        //            sp.ExecuteNonQuery();
        //        }
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            if (line.Length > 0)
        //            {
        //                //string shipto = line.Substring(145, 5) + "-" + line.Substring(22, 6);
        //                if ((line.Substring(140, 5) == "45320" || line.Substring(140, 5) == "05386") && line.Substring(10, 12) != "000000000000")
        //                //if ((line.Substring(140, 5).Trim() == "CRS1" || line.Substring(140, 5) == "45320") && line.Substring(10, 12) != "000000000000")
        //                {
        //                    //string[] item = line.Split(Convert.ToChar("|"));
        //                    MyCompany.Models.THMOrderImport Order = new MyCompany.Models.THMOrderImport();
        //                    Order.OrderBy = CustCode;
        //                    Order.DeliveryDestination = ""; //Not sure
        //                    Order.CustomerMatCode = line.Substring(28, 18).Replace(" ","");
        //                    Order.PartsDevision = "1";
        //                    Order.CustomerPO = line.Substring(10, 12);
        //                    Order.ReliabilityDevision = "P";
        //                    Order.DeliveryDate =Convert.ToDateTime( line.Substring(118, 4) + "-" + line.Substring(122, 2) + "-" + line.Substring(124, 2));
        //                    Order.Quantity = float.Parse(line.Substring(126, 7)).ToString().Trim();
        //                    Order.Unit = "ST";
        //                    Order.PlngPeriod = "D";
        //                    string[] materialTemp = SharedBusinessRules.getMaterial(Order.CustomerMatCode, Order.OrderBy, PlantCode, LocationCode).Split(':');
        //                    if (materialTemp.Length > 1)
        //                    {
        //                        Order.SAPCode = materialTemp[0];
        //                        Order.PartsDevision = materialTemp[1];
        //                        Order.DeliveryDestinationCode = materialTemp[2];
        //                    }
        //                    Order.Insert();                                               
                            
        //                }

        //            }
        //        }
        //        sr.Close();
        //    }

        //}

        
    }
}