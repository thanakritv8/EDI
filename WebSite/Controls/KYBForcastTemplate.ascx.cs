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




public partial class Controls_KYBForcastTemplate : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("KYB_{0}_FORCAST_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);



        // HATC Order
        string CustCode = "40120010";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
            string sql = null;
            //MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=D:\ROKI\WorkEDI\EDI DATA_20170301\SD\KMT\Forecast_KMT.xls;Extended Properties=Excel 8.0;HDR=YES;IMEX=1;");
            //MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filename + "';Extended Properties='Excel 12.0;HDR=YES;'");
            MyConnection = new System.Data.OleDb.OleDbConnection(
                            "provider=Microsoft.Jet.OLEDB.4.0;data source="
                            + filename
                            + ";Extended Properties=Excel 8.0;");
            //provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Programming\\Spreadsheet-Current.xlsx';Extended Properties='Excel 12.0;HDR=YES;'
            MyConnection.Open();
            myCommand.Connection = MyConnection;
            sql = "select * from [Sheet1$]";
            myCommand.CommandText = sql;
            //OleDbDataReader reader = myCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    var val1 = reader[0].ToString();
            //}            
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, MyConnection);            
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyConnection.Close();
            if (dt.Rows.Count > 0)
            {
                using (SqlProcedure sp = new SqlProcedure("sp_KYB_Forcast_ClearData"))
                {
                    sp.ExecuteNonQuery();
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][2].ToString().Trim() != "")
                    {
                        MyCompany.Data.Objects.KYBForcastImport Order = new MyCompany.Data.Objects.KYBForcastImport();

                        Order.OrderBy = CustCode;
                        Order.DeliveryDestination = "";
                        Order.CustomerMatCode = dt.Rows[i][2].ToString().Trim();
                        Order.PartsDevision = "1";
                        Order.CustomerPO = "";//dt.Rows[i][7].ToString().Trim();
                        Order.ReliabilityDevision = "P";
                        string[] spritDate = dt.Rows[i][6].ToString().Trim().Split(Convert.ToChar("/"));
                        if (spritDate.Length == 3)
                        {
                            Order.DeliveryDate =Convert.ToDateTime( spritDate[2] + "-" + Convert.ToInt32(spritDate[1]).ToString("0#") + "-" + spritDate[0]);
                        }
                        else
                        {
                            Order.DeliveryDate = null;
                        }
                        //Order.DeliveryDate = dt.Rows[i][6].ToString().Trim();
                        Order.Quantity = dt.Rows[i][5].ToString().Trim();
                        Order.Unit = "ST";
                        Order.PlngPeriod = "D";
                        Order.SAPCode = "";//SharedBusinessRules.getSAPCode(Order.CustomerMatCode);
                        Order.Insert();
                    }
                }
                
            }

            

        }


    }
}