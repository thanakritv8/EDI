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




public partial class Controls_TSMOrderTemplate : System.Web.UI.UserControl
{

    class MQtyOrder
    {
        public int OrderQty { get; set; }
        public string OrderDate { get; set; }
        public int startPosition { get; set; }
        public int endPosition { get; set; }
    }
    public static string[] ParseCsvRow(string csvrow)
    {
        StringBuilder txt = new StringBuilder(csvrow);
        if (csvrow.Contains(Convert.ToChar('"')) == true)
        {

            //csvrow = csvrow.Replace(",","");
            int flagStart = 0;
            for (int i = 0; i < csvrow.Length; i++)
            {

                //Start
                if (flagStart == 0)
                {
                    if (txt[i] == '"')
                    {
                        txt[i] = ' ';
                        //csvrow = txt.ToString().Trim();
                        flagStart = 1;
                    }
                }
                else
                {
                    if (txt[i] == ',')
                    {
                        txt[i] = ' ';
                        //csvrow = txt.ToString().Trim();
                    }
                    if (txt[i] == '"')
                    {
                        txt[i] = ' ';
                        //csvrow = txt.ToString().Trim();
                        flagStart = 0;
                    }
                }
            }
        }

        csvrow = txt.ToString().Trim();
        return csvrow.Split(Convert.ToChar(","));

         }
    public static bool IsDateTime(string txtDate)
    {
        DateTime tempDate;

        return DateTime.TryParse(txtDate, out tempDate) ? true : false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    #region ForecastImportMonth
    //if (line.Trim().Length > 0)
    //                {
    //                    string[] item = ParseCsvRow(line);
    //                    //Head
    //                    if (item.Length == 9)
    //                    {
    //                        if (IsDateTime(item[8]) == true)
    //                        {
    //                            IssueDate = Convert.ToDateTime(item[8].Trim());
    //                            //MessageBox.Show(item[8]);

    //                            for (int iMonth = 2; iMonth < item.Length - 1; iMonth++)
    //                            {
    //                                //List<String> itemHead = new List<string>();
    //                                int month = DateTime.Parse("1/" + item[iMonth] + "/2008").Month;
    //                                if (month < IssueDate.Month)
    //                                {
    //                                    itemHead.Add("01/" + month.ToString("0#") + "/" + (Convert.ToInt32(item[8].Trim().Substring(6)) + 1).ToString().Trim());
    //                                }
    //                                else
    //                                {
    //                                    itemHead.Add("01/" + month.ToString("0#") + item[8].Substring(6).Trim());
    //                                }
    //                                //MessageBox.Show(month.ToString());
    //                                //itemHead
    //                            }
    //                        }
    //                        //itemHead = item;
    //                    }
    //                    //Detail
    //                    if (item.Length == 8)
    //                    {
    //                        for (int iMonth = 0; iMonth < itemHead.Count; iMonth++)
    //                        {
    //                            MyCompany.Data.Objects.TSMForcastMonthImport Order = new MyCompany.Data.Objects.TSMForcastMonthImport();
    //                            Order.OrderBy = CustCode;
    //                            Order.DeliveryDestination = "";
    //                            Order.CustomerMatCode = item[0];
    //                            Order.PartsDevision = "1";
    //                            Order.CustomerPO = "";
    //                            Order.ReliabilityDevision = "P";
    //                            Order.DeliveryDate = itemHead[iMonth];
    //                            Order.Quantity = item[iMonth + 2];
    //                            Order.Unit = "ST";
    //                            Order.PlngPeriod = "D";
    //                            Order.SAPCode = SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
    //                            Order.Insert();
    //                            //MT05 result = new MT05();
    //                            //result.OrderBy = CustomerCode;
    //                            //result.DeliveryDesination = CustDesination;
    //                            //result.CustomerMatCode = item[0];
    //                            //result.PartsDivision = "1";
    //                            //result.CustomerPONo = "Not sure";
    //                            //result.ReliabilityDivision = "P";
    //                            //result.DeliveryDate = itemHead[iMonth];
    //                            //result.Quantity = Convert.ToInt32(item[iMonth + 2]);
    //                            //result.Unit = "ST";
    //                            //result.PIngPeriod = "D";
    //                            //Data.Add(result);
    //                        }

    //                    }


    //                }
    #endregion

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("TSM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40102010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                string CustPartNo = "";
                string CustDesination = "";
                bool flagGetPostion = false;
                DateTime IssueDate;
                List<MQtyOrder> colDate = new List<MQtyOrder>();
                List<String> itemHead = new List<string>();
                using (SqlProcedure sp = new SqlProcedure("sp_TSM_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {

                    if (line.Length > 0)
                    {
                        if (!line.Contains("ROKI") && !line.Contains("PKTXT") && !line.Contains("DEL"))
                        {
                            MyCompany.Data.Objects.TSMOrderImport Order = new MyCompany.Data.Objects.TSMOrderImport();
                            string[] item = ParseCsvRow(line);                
                            Order.OrderBy = CustCode;
                            Order.DeliveryDestination = item[2].Trim();
                            Order.CustomerMatCode = item[3].Trim();
                            Order.PartsDevision = "1";
                            Order.CustomerPO = item[7].Trim();
                            Order.ReliabilityDevision = "P";
                            string[] spritDate = item[10].Trim().Split(Convert.ToChar("/"));
                            if (spritDate.Length == 3)
                            {
                                Order.DeliveryDate =Convert.ToDateTime( DateTime.Today.Year.ToString().Substring(0,2) + spritDate[2] + "-" + Convert.ToInt32(spritDate[1]).ToString("0#") + "-" + spritDate[0]);
                            }
                            else
                            {
                                Order.DeliveryDate = null;
                            }
                            //Order.DeliveryDate = item[10];
                            Order.Quantity = float.Parse(item[9].Trim()).ToString().Trim();
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