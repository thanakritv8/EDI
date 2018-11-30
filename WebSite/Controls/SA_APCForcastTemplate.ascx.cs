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



public partial class Controls_SA_APCForcastTemplate : System.Web.UI.UserControl
{

    class MIndex
    {
        public string iMonth { get; set; }
        public int iTotal { get; set; }
        //public int startPosition { get; set; }
        //public int endPosition { get; set; }
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
    public bool IsDateTime(string txtDate)
    {
        DateTime tempDate;

        return DateTime.TryParse(txtDate, out tempDate) ? true : false;
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
        string CustCode = "40106010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {

            //List<MT05> Data = new List<MT05>();
            string CustomerCode = "SAAPC";
            DataTable dt = new DataTable();
            try
            {

                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                //MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=D:\ROKI\WorkEDI\EDI DATA_20170301\SD\KMT\Forecast_KMT.xls;Extended Properties=Excel 8.0;HDR=YES;IMEX=1;");
                //string filename = @"D:\ROKI\WorkEDI\EDI DATA_20170301\SD\NMT_X\NMT\GeneralForecast20160622.csv";
                //string filename = @"D:\ROKI\WorkEDI\EDI DATA_20170301\SA\APC\Oct\2016-11_FORECAST ORDER 05386-45320_EDI.xls";
                MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filename + "';Extended Properties='Excel 12.0;HDR=YES;'");
                //provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Programming\\Spreadsheet-Current.xlsx';Extended Properties='Excel 12.0;HDR=YES;'
                MyConnection.Open();
                DataTable dtSheet = MyConnection.GetSchema("Tables");
                string SheetName = dtSheet.Rows[0]["TABLE_NAME"].ToString().Trim();
                myCommand.Connection = MyConnection;
                //sql = "select * from [05386-45320$]";
                sql = "select * from [" + SheetName + "]";
                myCommand.CommandText = sql;
                OleDbDataReader reader = myCommand.ExecuteReader();

                //while (reader.Read())
                //{
                    //var val1 = reader[0].ToString();
                //}
                //myCommand.ExecuteNonQuery();
                //System.Data.OleDb.OleDbDataReader dr = new System.Data.OleDb.OleDbDataReader();
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, MyConnection);
                //Dim y As New Odbc.OdbcDataAdapter(sql, MyConnection);
                //dr = myCommand.ExecuteReader();

                da.Fill(dt);
                MyConnection.Close();
                //MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            string issueDate = "";
            if (dt.Rows.Count > 0)
            {
                issueDate = dt.Rows[4][5].ToString().Trim();
                issueDate = issueDate.Replace("ISSUED DATE : ", " ");
                List<MIndex> itemHead = new List<MIndex>();
                using (SqlProcedure sp = new SqlProcedure("sp_APC_ForcastMonth_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string mergeDate = "01/" + dt.Rows[6][i].ToString().Trim() + "/2008";
                    //mergeDate = mergeDate;
                    if (IsDateTime(mergeDate) == true)
                    {
                        if (IsDateTime("01/" + dt.Rows[6][i + 3].ToString().Trim() + "/2008") == true)
                        {
                            //MessageBox.Show(mergeDate);                            
                            MIndex iMonth = new MIndex();
                            if (Convert.ToDateTime(issueDate).Month < Convert.ToDateTime(mergeDate).Month)
                            {
                                if (Convert.ToDateTime(issueDate).Year < 2000)
                                {
                                    iMonth.iMonth = "01/" + dt.Rows[6][i].ToString().Trim() + "/" + (Convert.ToDateTime(issueDate).Year + 543).ToString();
                                }
                                else
                                {
                                    iMonth.iMonth = "01/" + dt.Rows[6][i].ToString().Trim() + "/" + Convert.ToDateTime(issueDate).Year.ToString();
                                }

                                iMonth.iTotal = i + 2;
                            }
                            else
                            {
                                if (Convert.ToDateTime(issueDate).Year < 2000)
                                {
                                    iMonth.iMonth = "01/" + dt.Rows[6][i].ToString().Trim() + "/" + (Convert.ToDateTime(issueDate).AddYears(1).Year + 543).ToString(); ;
                                }
                                else
                                {
                                    iMonth.iMonth = "01/" + dt.Rows[6][i].ToString().Trim() + "/" + Convert.ToDateTime(issueDate).AddYears(1).Year.ToString(); ;
                                }
                                iMonth.iTotal = i + 2;
                            }
                            itemHead.Add(iMonth);
                        }
                        else
                        {
                            if (dt.Rows[6][i + 3].ToString().Trim() == "DROP")
                            {
                                //MessageBox.Show("Finish");
                                break;
                            }
                        }

                    }

                }
                if (itemHead.Count > 0)
                {
                    for (int j = 9; j < dt.Rows.Count; j++)
                    {
                        if (SetNumber(dt.Rows[j][5].ToString().Trim()) > 0)
                        {

                            //MessageBox.Show(dt.Rows[j][5].ToString().Trim());
                            for (int iHead = 0; iHead < itemHead.Count; iHead++)
                            {
                                MyCompany.Data.Objects.APCForcastMonthImport Order = new MyCompany.Data.Objects.APCForcastMonthImport();
                                Order.OrderBy = CustCode;
                                Order.DeliveryDestination = "";
                                Order.CustomerMatCode = dt.Rows[j][6].ToString().Trim();
                                Order.PartsDevision = "1";
                                Order.CustomerPO = "";
                                Order.ReliabilityDevision = "P";
                                Order.Unit = "ST";
                                Order.PlngPeriod = "D";
                                Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                                //Order.DeliveryDate = itemHead[iHead].iMonth;
                                Order.DeliveryDate = Convert.ToDateTime(itemHead[iHead].iMonth.ToString().Substring(7, 4) + "-" + itemHead[iHead].iMonth.ToString().Substring(3, 3) + "-" + itemHead[iHead].iMonth.ToString().Substring(0,2));
                                Order.Quantity = SetNumber(dt.Rows[j][itemHead[iHead].iTotal].ToString().Trim().Replace(",", "")).ToString().Trim();                                       
                                Order.Insert();
                                //MT05 result = new MT05();
                                //result.OrderBy = CustomerCode;
                                //result.DeliveryDesination = "";
                                //result.CustomerMatCode = dt.Rows[j][6].ToString().Trim();
                                //result.PartsDivision = "1";
                                //result.CustomerPONo = "Not sure";
                                //result.ReliabilityDivision = "P";
                                //result.DeliveryDate = itemHead[iHead].iMonth;
                                //result.Quantity = SetNumber(dt.Rows[j][itemHead[iHead].iTotal].ToString().Trim().Replace(",", ""));
                                //result.Unit = "ST";
                                //result.PIngPeriod = "D";
                                //Data.Add(result);

                            }

                        }
                    }
                }
            }




        }

        
    }
}
