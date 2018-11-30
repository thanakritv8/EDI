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



public partial class Controls_KYBOrderTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected string[] ParseCsvRow(string csvrow)
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

        //const string obscureCharacter = "ᖳ";
        //if (csvrow.Contains(obscureCharacter)) throw new Exception("Error: csv row may not contain the " + obscureCharacter + " character");

        //var unicodeSeparatedString = "";

        //var quotesArray = csvrow.Split('"');  // Split string on double quote character
        //if (quotesArray.Length > 1)
        //{
        //    for (var i = 0; i < quotesArray.Length; i++)
        //    {
        //        // CSV must use double quotes to represent a quote inside a quoted cell
        //        // Quotes must be paired up
        //        // Test if a comma lays outside a pair of quotes.  If so, replace the comma with an obscure unicode character
        //        if (Math.Round(Math.Round((decimal)i / 2) * 2) == i)
        //        {
        //            var s = quotesArray[i].Trim();
        //            switch (s)
        //            {
        //                case ",":
        //                    quotesArray[i] = obscureCharacter;  // Change quoted comma seperated string to quoted "obscure character" seperated string
        //                    break;
        //            }
        //        }
        //        // Build string and Replace quotes where quotes were expected.
        //        unicodeSeparatedString += (i > 0 ? "\"" : "") + quotesArray[i].Trim();
        //    }
        //}
        //else
        //{
        //    // String does not have any pairs of double quotes.  It should be safe to just replace the commas with the obscure character
        //    unicodeSeparatedString = csvrow.Replace(",", obscureCharacter);
        //}

        //var csvRowArray = unicodeSeparatedString.Split(obscureCharacter[0]);

        //for (var i = 0; i < csvRowArray.Length; i++)
        //{
        //    var s = csvRowArray[i].Trim();
        //    if (s.StartsWith("\"") && s.EndsWith("\""))
        //    {
        //        csvRowArray[i] = s.Length > 2 ? s.Substring(1, s.Length - 2) : "";  // Remove start and end quotes.
        //    }
        //}

        //return csvRowArray;
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("KYB_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40120010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_KYB_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        if (line.Length > 0 && !line.Contains("Unshipped Qty") && !line.Contains("Past Due Net"))
                        {
                            string[] item = ParseCsvRow(line);
                            MyCompany.Data.Objects.KYBOrderImport Order = new MyCompany.Data.Objects.KYBOrderImport();
                            Order.OrderBy = CustCode;
                            Order.DeliveryDestination = "";
                            Order.CustomerMatCode = item[4].Trim();
                            Order.PartsDevision = "1A";
                            Order.CustomerPO = item[2].Trim();
                            Order.ReliabilityDevision = "P";
                            string[] spritDate = item[0].Trim().Split(Convert.ToChar("/"));
                            if (spritDate.Length == 3)
                            {
                                Order.DeliveryDate = Convert.ToDateTime(spritDate[2] + "-" + Convert.ToInt32(spritDate[1]).ToString("0#") + "-" + spritDate[0]);
                            }
                            else
                            {
                                Order.DeliveryDate = null;
                            }
                            //Order.DeliveryDate = item[0].Replace("/", "");
                            Order.Quantity = float.Parse(item[7].Replace(" ", "")).ToString().Trim();
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

        //// Forcast

        //string CustomerCode = "";
        //string Desination = "";
        ////BindDataT05(CustomerCode, "HATC", "ODB");
        //List<MT05> Data = new List<MT05>();
        //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //{
        //    string path = openFileDialog1.FileName.ToString().Trim();
        //    ////Import File to Datatable
        //    string line;
        //    // Read the file and display it line by line.
        //    System.IO.StreamReader file =
        //           new System.IO.StreamReader(path);
        //    try
        //    {
        //        int rowsCount = 0;
        //        int i = 0;
        //        List<string> str = new List<string>();

        //        string CustPartNo = "";
        //        while ((line = file.ReadLine()) != null)
        //        {
        //            rowsCount++;
        //            MT05 T05 = new MT05();
        //            if (rowsCount % 16 == 0)
        //            {

        //                //Get Customer code
        //                CustomerCode = str[2].Substring(5, 10).Trim();
        //                Desination = str[9].Substring(8, 10).Trim();
        //                //Get Customer Part No && Array Date
        //                //string[] arrStrLine6;
        //                //arrStrLine6 = str[5].Split(Convert.ToChar(" "));
        //                //int getRow5 = 0;
        //                List<MQtyOrder> QtyOfDate = new List<MQtyOrder>();
        //                //CustPartNo = str[5].Split(Convert.ToChar(" "));
        //                CustPartNo = str[5].Substring(0, 31);
        //                #region DateOfOrder
        //                if (str[5].Substring(33, 4) == "DATE")
        //                {
        //                    //MessageBox.Show("Line OK");
        //                    string Month = "";
        //                    int startPostition = 0;
        //                    int endPostition = 0;
        //                    string flagPosition = "End";
        //                    //string flagSavePosition = "No";
        //                    //Merge stirng Date
        //                    for (int iRow5 = 37; iRow5 < str[5].Length; iRow5++)
        //                    {
        //                        if (str[5].Substring(iRow5, 1) != " ")
        //                        {
        //                            if (flagPosition == "End")
        //                            {
        //                                startPostition = iRow5;
        //                                flagPosition = "Start";
        //                            }
        //                            if (str[5].Substring(iRow5, 5) == "TOTAL")
        //                            {
        //                                //MessageBox.Show("End Line !!!");
        //                                //return;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                Month = Month + str[5].Substring(iRow5, 1);
        //                            }

        //                        }
        //                        else
        //                        {
        //                            if (flagPosition == "Start")
        //                            {
        //                                //flagPosition = "End";
        //                                //}
        //                                flagPosition = "End";
        //                                endPostition = iRow5;
        //                                //flagSavePosition = "NO";
        //                            }
        //                            if (Month != "")
        //                            {
        //                                //Save Date
        //                                MQtyOrder Qty = new MQtyOrder();
        //                                Qty.OrderDate = Month;
        //                                Qty.startPosition = startPostition;
        //                                Qty.endPosition = endPostition;
        //                                QtyOfDate.Add(Qty);
        //                                //MessageBox.Show(Month + " : " + startPostition + "," + endPostition);
        //                                Month = "";
        //                            }
        //                        }
        //                    }
        //                #endregion
        //                    #region QtyOfOrder
        //                    if (str[6].Substring(33, 4) == "QTY.")
        //                    {
        //                        //for (int iRow6 = 37; iRow6 < str[6].Length; iRow6++)
        //                        //{

        //                        //}
        //                        for (int iQty = 0; iQty < QtyOfDate.Count; iQty++)
        //                        {
        //                            //MQtyOrder Qty = new MQtyOrder();
        //                            //Qty = QtyOfDate[iQty];
        //                            //Qty.OrderQty = 
        //                            string Qty = str[6].Substring(QtyOfDate[iQty].startPosition, QtyOfDate[iQty].endPosition - QtyOfDate[iQty].startPosition).ToString().Trim();
        //                            if (Qty == "")
        //                            {
        //                                QtyOfDate[iQty].OrderQty = 0;
        //                            }
        //                            else
        //                            {
        //                                QtyOfDate[iQty].OrderQty = Convert.ToInt32(Qty);
        //                            }
        //                            //QtyOfDate[iQty].OrderQty = str[6].Substring(QtyOfDate[iQty].startPosition, QtyOfDate[iQty].endPosition - QtyOfDate[iQty].startPosition);
        //                        }
        //                    }
        //                    #endregion
        //                    #region ShowData
        //                    //List<MT05> Data = new List<MT05>();
        //                    for (int iShow = 0; iShow < QtyOfDate.Count; iShow++)
        //                    {
        //                        MT05 result = new MT05();
        //                        result.OrderBy = CustomerCode;
        //                        result.DeliveryDesination = Desination;
        //                        result.CustomerMatCode = CustPartNo;
        //                        result.PartsDivision = "1";
        //                        result.CustomerPONo = "Not sure";
        //                        result.ReliabilityDivision = "P";
        //                        result.DeliveryDate = QtyOfDate[iShow].OrderDate;
        //                        result.Quantity = QtyOfDate[iShow].OrderQty;
        //                        result.Unit = "ST";
        //                        result.PIngPeriod = "D";
        //                        Data.Add(result);
        //                    }
        //                    #endregion
        //                    str.Clear();
        //                    //rowsCount = 1;
        //                }

        //            }
        //            else
        //            {
        //                str.Add(line);
        //            }
        //        }
        //        dgvData.DataSource = Data;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}