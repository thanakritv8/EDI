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

public partial class Controls_FileImportTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        //// Save file
        //string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        //AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        //// HATC Order
        //string CustCode = "40138011";
        //filename = Server.MapPath("~/Files/") + filename;
        //if (File.Exists(filename))
        //{
        //    string line = string.Empty;
        //    using (StreamReader sr = new StreamReader(filename))
        //    {
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            if (line.Length > 0)
        //            {
        //                #region Format
        //                string shipto = line.Substring(145, 5) + "-" + line.Substring(22, 6);
        //                if ((line.Substring(140, 5) == "45320" || line.Substring(140, 5) == "05386") && line.Substring(10, 12) != "000000000000")
        //                {
        //                    MyCompany.Data.Objects.HATCOrderImport Order = new MyCompany.Data.Objects.HATCOrderImport();

        //                    Order.OrderBy = CustCode;
        //                    Order.DeliveryDestination = CustCode;
        //                    Order.CustomerMatCode = line.Substring(28, 18).Replace(" ", "");
        //                    Order.PartsDevision = "1";
        //                    Order.CustomerPO = line.Substring(10, 12);
        //                    Order.ReliabilityDevision = "P";
        //                    Order.DeliveryDate =Convert.ToDateTime( line.Substring(124, 2) + line.Substring(122, 2) + line.Substring(118, 4));
        //                    Order.Quantity = line.Substring(126, 7);
        //                    Order.Unit = "ST";
        //                    Order.PlngPeriod = "D";
        //                    Order.SAPCode = SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
        //                    Order.Insert();
        //                }
        //                #endregion
        //            }
        //        }
        //        sr.Close();
        //    }

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
    //}
}
