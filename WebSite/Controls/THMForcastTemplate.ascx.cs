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




public partial class Controls_THMForcastTemplate : System.Web.UI.UserControl
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
        filename = String.Format("THM_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40101010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                int rowsCount = 0;
                int i = 0;
                List<string> str = new List<string>();

                string CustPartNo = string.Empty, CustomerCode = string.Empty, Desination = string.Empty;
                using (SqlProcedure sp = new SqlProcedure("sp_THM_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    rowsCount++;
                    if (rowsCount % 16 == 0)
                    {

                        //Get Customer code
                        CustomerCode = str[2].Substring(5, 10).Trim();
                        Desination = str[9].Substring(8, 10).Trim();
                        //Get Customer Part No && Array Date
                        //string[] arrStrLine6;
                        //arrStrLine6 = str[5].Split(Convert.ToChar(" "));
                        //int getRow5 = 0;
                        List<MQtyOrder> QtyOfDate = new List<MQtyOrder>();
                        //CustPartNo = str[5].Split(Convert.ToChar(" "));
                        CustPartNo = str[5].Substring(0, 31);
                        #region DateOfOrder
                        if (str[5].Substring(33, 4) == "DATE")
                        {
                            //MessageBox.Show("Line OK");
                            string Month = "";
                            int startPostition = 0;
                            int endPostition = 0;
                            string flagPosition = "End";
                            //string flagSavePosition = "No";
                            //Merge stirng Date
                            for (int iRow5 = 37; iRow5 < str[5].Length; iRow5++)
                            {
                                if (str[5].Substring(iRow5, 1) != " ")
                                {
                                    if (flagPosition == "End")
                                    {
                                        startPostition = iRow5;
                                        flagPosition = "Start";
                                    }
                                    if (str[5].Substring(iRow5, 5) == "TOTAL")
                                    {
                                        //MessageBox.Show("End Line !!!");
                                        //return;
                                        break;
                                    }
                                    else
                                    {
                                        Month = Month + str[5].Substring(iRow5, 1);
                                    }

                                }
                                else
                                {
                                    if (flagPosition == "Start")
                                    {
                                        //flagPosition = "End";
                                        //}
                                        flagPosition = "End";
                                        endPostition = iRow5;
                                        //flagSavePosition = "NO";
                                    }
                                    if (Month != "")
                                    {
                                        //Save Date
                                        MQtyOrder Qty = new MQtyOrder();
                                        Qty.OrderDate = Month;
                                        Qty.startPosition = startPostition;
                                        Qty.endPosition = endPostition;
                                        QtyOfDate.Add(Qty);
                                        //MessageBox.Show(Month + " : " + startPostition + "," + endPostition);
                                        Month = "";
                                    }
                                }
                            }
                        #endregion
                            #region QtyOfOrder
                            if (str[6].Substring(33, 4) == "QTY.")
                            {
                                //for (int iRow6 = 37; iRow6 < str[6].Length; iRow6++)
                                //{

                                //}
                                for (int iQty = 0; iQty < QtyOfDate.Count; iQty++)
                                {
                                    //MQtyOrder Qty = new MQtyOrder();
                                    //Qty = QtyOfDate[iQty];
                                    //Qty.OrderQty = 
                                    string Qty = str[6].Substring(QtyOfDate[iQty].startPosition, QtyOfDate[iQty].endPosition - QtyOfDate[iQty].startPosition).ToString().Trim();
                                    if (Qty == "")
                                    {
                                        QtyOfDate[iQty].OrderQty = 0;
                                    }
                                    else
                                    {
                                        QtyOfDate[iQty].OrderQty = Convert.ToInt32(Qty);
                                    }
                                    //QtyOfDate[iQty].OrderQty = str[6].Substring(QtyOfDate[iQty].startPosition, QtyOfDate[iQty].endPosition - QtyOfDate[iQty].startPosition);
                                }
                            }
                            #endregion
                            #region ShowData
                            //List<MT05> Data = new List<MT05>();
                            for (int iShow = 0; iShow < QtyOfDate.Count; iShow++)
                            {
                                MyCompany.Data.Objects.THMForcastImport Order = new MyCompany.Data.Objects.THMForcastImport();
                                Order.OrderBy = CustomerCode;
                                Order.DeliveryDestination = Desination;
                                Order.CustomerMatCode = CustPartNo;
                                Order.PartsDevision = "1";
                                Order.CustomerPO = "Not sure";
                                Order.ReliabilityDevision = "P";
                                //Order.DeliveryDate = QtyOfDate[iShow].OrderDate;
                                //Order.Quantity = Convert.ToDecimal( QtyOfDate[iShow].OrderQty);
                                Order.Unit = "ST";
                                Order.PlngPeriod = "D";
                                Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                Order.Insert();

                            }
                            #endregion
                            str.Clear();
                            //rowsCount = 1;
                        }

                    }
                    else
                    {
                        str.Add(line);
                    }
                }
                sr.Close();
            }
        }
    }
}