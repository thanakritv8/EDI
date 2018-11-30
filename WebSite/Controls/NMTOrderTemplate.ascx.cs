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



public partial class Controls_NMTOrderTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("NMT_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
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
                                string[] orderData = data[i].Split('-');
                                if (orderData.Length > 1)
                                {
                                    int OrderDate = 0;
                                    Int32.TryParse(orderData[0], out OrderDate);
                                    if (OrderDate > 0)
                                    {
                                        // Is Delivery Date

                                        string DeliveryDate = String.Format("{0:00}", OrderDate);
                                        switch (orderData[1].ToLower())
                                        {
                                            case "jan": DeliveryDate = "-01-" + DeliveryDate;
                                                break;
                                            case "feb": DeliveryDate = "-02-" + DeliveryDate;
                                                break;
                                            case "mar": DeliveryDate = "-03-" + DeliveryDate;
                                                break;
                                            case "apl": DeliveryDate = "-04-" + DeliveryDate;
                                                break;
                                            case "may": DeliveryDate = "-05-" + DeliveryDate;
                                                break;
                                            case "jun": DeliveryDate = "-06-" + DeliveryDate;
                                                break;
                                            case "jul": DeliveryDate = "-07-" + DeliveryDate;
                                                break;
                                            case "aug": DeliveryDate = "-08-" + DeliveryDate;
                                                break;
                                            case "sep": DeliveryDate = "-09-" + DeliveryDate;
                                                break;
                                            case "oct": DeliveryDate = "-10-" + DeliveryDate;
                                                break;
                                            case "nov": DeliveryDate = "-11-" + DeliveryDate;
                                                break;
                                            case "dec": DeliveryDate = "-12-" + DeliveryDate;
                                                break;

                                        }
                                        // DataIndexing , Month and date
                                        if (!DueDate.ContainsKey(i))
                                        {
                                            DueDate.Add(i, DeliveryDate);
                                        }

                                    }
                                    else
                                    {
                                        // Forcast
                                    }
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            // RowData
                            if (!String.IsNullOrEmpty(data[236].Trim()))
                            {
                                foreach (KeyValuePair<int, string> item in DueDate)
                                {
                                    int Qty = 0;
                                    Int32.TryParse(data[item.Key], out Qty);

                                    MyCompany.Data.Objects.NMTOrderImport Order = new MyCompany.Data.Objects.NMTOrderImport();
                                    Order.OrderBy = CustCode;
                                    Order.DeliveryDestination = data[10].ToString().Trim();
                                    Order.CustomerMatCode = data[4].Trim();
                                    Order.PartsDevision = "1";
                                    Order.CustomerPO = "";
                                    Order.ReliabilityDevision = "P";
                                    Order.DeliveryDate = Convert.ToDateTime(data[236] + item.Value);
                                    Order.Quantity = Qty.ToString().Trim();
                                    Order.Unit = "ST";
                                    Order.PlngPeriod = "D";
                                    Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                    Order.Insert();
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
