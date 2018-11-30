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



public partial class Controls_SA_THMForcastTemplate : System.Web.UI.UserControl
{
    class MQtyOrder
    {
        public int OrderQty { get; set; }
        public string OrderDate { get; set; }
        public int startPosition { get; set; }
        public int endPosition { get; set; }
    }
    public int SetNumber(string n)
    {
        int nVal = 0;
        int number;
        if (int.TryParse(n, out nVal))
        {
            if (nVal < 0)
                number = Math.Abs(nVal);
            else
                number = nVal;
        }
        else
        {
            number = 0;
        }
        return number;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40101010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                string CustPartNo = "";
                string CustDesination = "";
                bool flagGetPostion = false;
                List<MQtyOrder> colDate = new List<MQtyOrder>();
                while ((line = sr.ReadLine()) != null)
                {

                    if (line.Trim().Length > 0)
                    {
                        if (line.Contains("LONG PLAN PRODUCTION FORECAST ORDER (MAIL)") == false)
                        {
                            if (line.Contains("NO.") == true && line.Contains("PARTS NO.") == true)
                            {
                                //get postion header forecase month
                                if (flagGetPostion == false)
                                {
                                    #region DateOfOrder
                                    //MessageBox.Show("Line OK");
                                    string Month = "";
                                    int startPostition = 0;
                                    int endPostition = 0;
                                    string flagPosition = "End";
                                    //string flagSavePosition = "No";
                                    //Merge stirng Date
                                    for (int iRow = 37; iRow < line.Length; iRow++)
                                    {
                                        if (line.Substring(iRow, 1) != " ")
                                        {
                                            if (flagPosition == "End")
                                            {
                                                startPostition = iRow;
                                                flagPosition = "Start";
                                            }
                                            if (line.Substring(iRow, 5) == "MONTH")
                                            {
                                                //MessageBox.Show("End Line !!!");
                                                //return;
                                                break;
                                            }
                                            else
                                            {
                                                Month = Month + line.Substring(iRow, 1);
                                            }

                                        }
                                        else
                                        {
                                            if (flagPosition == "Start")
                                            {
                                                //flagPosition = "End";
                                                //}
                                                flagPosition = "End";
                                                endPostition = iRow;
                                                //flagSavePosition = "NO";
                                            }
                                            if (Month != "")
                                            {
                                                //Save Date
                                                MQtyOrder Qty = new MQtyOrder();
                                                Qty.OrderDate = Month;
                                                Qty.startPosition = startPostition;
                                                Qty.endPosition = endPostition;
                                                colDate.Add(Qty);
                                                //MessageBox.Show(Month + " : " + startPostition + "," + endPostition);
                                                Month = "";
                                            }
                                        }
                                    }

                                    #endregion
                                    flagGetPostion = true;
                                    //break;
                                }

                            }
                            else
                            {
                                //if (line.Substring(40, 10).Trim() != "" && line.Substring(127, 5).Trim() != "Total")
                                if (line.Substring(0, 5) != " " && SetNumber(line.Substring(0, 5)) > 0)
                                {
                                    if (flagGetPostion == true)
                                    {
                                        #region QtyOfOrder

                                        //Get SKU
                                        if (line.Substring(6, 1) != " ")
                                        {
                                            CustPartNo = line.Substring(6, 18).Trim();
                                        }
                                        //Get Qty
                                        for (int iQty = 0; iQty < colDate.Count; iQty++)
                                        {
                                            //MQtyOrder Qty = new MQtyOrder();
                                            //Qty = QtyOfDate[iQty];
                                            //Qty.OrderQty = 
                                            string Qty = line.Substring(colDate[iQty].startPosition, colDate[iQty].endPosition - colDate[iQty].startPosition).ToString().Trim();
                                            if (Qty == "")
                                            {
                                                colDate[iQty].OrderQty = 0;
                                            }
                                            else
                                            {
                                                colDate[iQty].OrderQty = Convert.ToInt32(Qty);
                                            }
                                            //QtyOfDate[iQty].OrderQty = str[6].Substring(QtyOfDate[iQty].startPosition, QtyOfDate[iQty].endPosition - QtyOfDate[iQty].startPosition);
                                        }

                                        #endregion
                                        //BindData to List Model
                                        #region BindData to List Model
                                        //List<MT05> Data = new List<MT05>();
                                        for (int iShow = 0; iShow < colDate.Count; iShow++)
                                        {
                                            MyCompany.Data.Objects.THMForcastMonthImport Order = new MyCompany.Data.Objects.THMForcastMonthImport();
                                            Order.OrderBy = CustCode;
                                            Order.DeliveryDestination = "";
                                            Order.CustomerMatCode = CustPartNo.Replace(" ","");
                                            Order.PartsDevision = "1";
                                            Order.CustomerPO = "";
                                            Order.ReliabilityDevision = "P";
                                            //Order.DeliveryDate = "01/" + colDate[iShow].OrderDate;
                                            string[] spritDate = ("01/" + colDate[iShow].OrderDate).Split(Convert.ToChar("/"));
                                            if (spritDate.Length == 3)
                                            {
                                                //DateTime.Today.Year.ToString().Substring(0, 2) + 
                                                Order.DeliveryDate = Convert.ToDateTime(spritDate[2] + "-" + Convert.ToInt32(spritDate[1]).ToString("0#") + "-" + spritDate[0]);
                                            }
                                            else
                                            {
                                                Order.DeliveryDate = null;
                                            }
                                            Order.Quantity = colDate[iShow].OrderQty.ToString();
                                            Order.Unit = "ST";
                                            Order.PlngPeriod = "D";
                                            Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                            Order.Insert();
                                            //MT05 result = new MT05();
                                            //result.OrderBy = CustCode;
                                            //result.DeliveryDesination = CustDesination;
                                            //result.CustomerMatCode = CustPartNo;
                                            //result.PartsDivision = "1";
                                            //result.CustomerPONo = "Not sure";
                                            //result.ReliabilityDivision = "P";
                                            //result.DeliveryDate = colDate[iShow].OrderDate;
                                            //result.Quantity = colDate[iShow].OrderQty;
                                            //result.Unit = "ST";
                                            //result.PIngPeriod = "D";
                                            //Data.Add(result);
                                        }
                                        #endregion
                                    }

                                }


                            }

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
