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
using System.Data;
using System.Data.OleDb;




public partial class Controls_KMTOrderTemplate : System.Web.UI.UserControl
{

    class MQtyOrder
    {
        public int OrderQty { get; set; }
        public string OrderDate { get; set; }
        public int startPosition { get; set; }
        public int endPosition { get; set; }
    }
    private DataSet ConvertHTMLTablesToDataSet(string HTML)
    {
        // Declarations    
        DataSet ds = new DataSet();
        DataTable dt = null;
        DataRow dr = null;
        string TableExpression = "<table[^>]*>(.*?)</table>";
        string HeaderExpression = "<th[^>]*>(.*?)</th>";
        string RowExpression = "<tr[^>]*>(.*?)</tr>";
        string ColumnExpression = "<td[^>]*>(.*?)</td>";
        bool HeadersExist = false;
        int iCurrentColumn = 0;
        int iCurrentRow = 0;

        // Get a match for all the tables in the HTML    
        MatchCollection Tables = Regex.Matches(HTML, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

        // Loop through each table element    
        foreach (Match Table in Tables)
        {

            // Reset the current row counter and the header flag    
            iCurrentRow = 0;
            HeadersExist = false;

            // Add a new table to the DataSet    
            dt = new DataTable();

            // Create the relevant amount of columns for this table (use the headers if they exist, otherwise use default names)    
            if (Table.Value.Contains("<td"))
            {
                // Set the HeadersExist flag    
                HeadersExist = true;

                // Get a match for all the rows in the table    
                MatchCollection Headers = Regex.Matches(Table.Value, ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                // Loop through each header element    
                //Fix Column By Patiphat
                int cCount = 1;
                foreach (Match Header in Headers)
                {
                    if (cCount > 18)
                    {
                        break;
                    }
                    if (!dt.Columns.Contains(Header.Groups[1].ToString()))
                        dt.Columns.Add(Header.Groups[1].ToString().Replace("&nbsp;", ""));
                    cCount++;
                }
            }
            else
            {
                for (int iColumns = 1; iColumns <= Regex.Matches(Regex.Matches(Regex.Matches(Table.Value, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).ToString(), RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).ToString(), ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).Count; iColumns++)
                {
                    dt.Columns.Add("Column " + iColumns);
                }
            }

            // Get a match for all the rows in the table    
            MatchCollection Rows = Regex.Matches(Table.Value, RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

            // Loop through each row element    
            foreach (Match Row in Rows)
            {

                // Only loop through the row if it isn't a header row    
                if (!(iCurrentRow == 0 & HeadersExist == true))
                {

                    // Create a new row and reset the current column counter    
                    dr = dt.NewRow();
                    iCurrentColumn = 0;

                    // Get a match for all the columns in the row    
                    MatchCollection Columns = Regex.Matches(Row.Value, ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                    // Loop through each column element    
                    foreach (Match Column in Columns)
                    {
                        if (Columns.Count - 1 != iCurrentColumn)
                            // Add the value to the DataRow    
                            dr[iCurrentColumn] = Convert.ToString(Column.Groups[1]).Replace("&nbsp;", "");

                        // Increase the current column     
                        iCurrentColumn += 1;
                    }

                    // Add the DataRow to the DataTable    
                    dt.Rows.Add(dr);

                }

                // Increase the current row counter    
                iCurrentRow += 1;
            }

            // Add the DataTable to the DataSet    
            ds.Tables.Add(dt);

        }

        return ds;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }



    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("KMT_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // HATC Order
        string CustCode = "40104010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            //int i = 0;     
            string line;
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                   new System.IO.StreamReader(filename);   
            //List<MQtyOrder> colDate = new List<MQtyOrder>();
            //List<String> itemHead = new List<string>();
            StringBuilder htmlString = new StringBuilder();
            while ((line = file.ReadLine()) != null)
            {
                htmlString.Append(line);
                htmlString.Append("\r\n");
            }
            DataSet ds = new DataSet();
            ds = ConvertHTMLTablesToDataSet(htmlString.ToString());
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MyCompany.Data.Objects.KMTOrderImport Order = new MyCompany.Data.Objects.KMTOrderImport();                    
                    Order.OrderBy = CustCode;
                    Order.DeliveryDestination = dt.Rows[i][5].ToString().Trim();
                    Order.CustomerMatCode = dt.Rows[i][1].ToString().Trim().Replace(" ","");
                    Order.PartsDevision = "1";
                    Order.CustomerPO = dt.Rows[i][3].ToString().Trim();
                    Order.ReliabilityDevision = "P";
                    string[] spritDate = dt.Rows[i][4].ToString().Trim().Split(Convert.ToChar("/"));
                    if (spritDate.Length == 3)
                    {
                        Order.DeliveryDate = Convert.ToDateTime(spritDate[2] + "-" + Convert.ToInt32(spritDate[1]).ToString("0#") + "-" + spritDate[0]);
                    }
                    else
                    {
                        Order.DeliveryDate = null;
                    }
                    Order.Quantity = float.Parse(dt.Rows[i][7].ToString().Trim()).ToString().Trim();
                    Order.Unit = "ST";
                    Order.PlngPeriod = "D";
                    Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                    Order.Insert();                                               
                    
                }                
            }



            //try
            //{
                
            //    System.Data.OleDb.OleDbConnection MyConnection;
            //    System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
            //    string sql = null;
            //    MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" + filename + ";Extended Properties=Excel 8.0;HDR=YES;IMEX=1;");
            //    MyConnection.Open();
            //    myCommand.Connection = MyConnection;
            //    sql = "select * from [Sheet1$]";
            //    myCommand.CommandText = sql;
            //    OleDbDataReader reader = myCommand.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var val1 = reader[0].ToString();
            //    }
            //    //myCommand.ExecuteNonQuery();
            //    //System.Data.OleDb.OleDbDataReader dr = new System.Data.OleDb.OleDbDataReader();
            //    System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, MyConnection);
            //    //Dim y As New Odbc.OdbcDataAdapter(sql, MyConnection);
            //    //dr = myCommand.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    MyConnection.Close();
            //    //MessageBox.Show("Success");
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.ToString());
            //}


            //string line = string.Empty;
            //using (StreamReader sr = new StreamReader(filename))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        if (line.Length > 0)
            //        {
            //            #region Format
            //            string shipto = line.Substring(145, 5) + "-" + line.Substring(22, 6);
            //            if ((line.Substring(140, 5) == "45320" || line.Substring(140, 5) == "05386") && line.Substring(10, 12) != "000000000000")
            //            {
            //                MyCompany.Data.Objects.HATCOrderImport Order = new MyCompany.Data.Objects.HATCOrderImport();

            //                Order.OrderBy = CustCode;
            //                Order.DeliveryDestination = CustCode;
            //                Order.CustomerMatCode = line.Substring(28, 18).Replace(" ", "");
            //                Order.PartsDevision = "1";
            //                Order.CustomerPO = line.Substring(10, 12);
            //                Order.ReliabilityDevision = "P";
            //                Order.DeliveryDate = line.Substring(124, 2) + line.Substring(122, 2) + line.Substring(118, 4);
            //                Order.Quantity = line.Substring(126, 7);
            //                Order.Unit = "ST";
            //                Order.PlngPeriod = "D";
            //                Order.SAPCode = SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
            //                Order.Insert();
            //            }
            //            #endregion
            //        }
            //    }
                //sr.Close();
            //}

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