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


public partial class Controls_AATForcastTemplate : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {

        // Save file
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        filename = String.Format("AAT_{0}_Forcast_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);

        // AAT
        string CustCode = "40116011";
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            DataTable dt = new DataTable();
            var connString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""", Path.GetDirectoryName(filename));
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    using (SqlProcedure sp = new SqlProcedure("sp_AAT_Forcast_ClearData"))
                    {
                        sp.ExecuteNonQuery();
                    }
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    var query = "SELECT * FROM [" + Path.GetFileName(filename) + "]";
                    using (var adapter = new OleDbDataAdapter(query, con))
                    {
                        adapter.Fill(dt);
                        if (dt.Columns.Count == 39)
                        {
                            bool boolStatusInsert = false;
                            foreach (DataRow _item in dt.Rows)
                            {
                                if (boolStatusInsert)
                                {
                                    if (_item[38].ToString() == "W")
                                    {
                                        MyCompany.Models.AATForcastImport forcast = new MyCompany.Models.AATForcastImport();
                                        forcast.OrderBy = CustCode;
                                        forcast.DeliveryDestination = _item[8].ToString();
                                        forcast.CustomerMatCode = _item[11].ToString();
                                        string[] materialTemp = SharedBusinessRules.getMaterial(_item[11].ToString(), CustCode, _item[8].ToString(), "AAT").Split(':');
                                        forcast.PartsDevision = materialTemp[1];
                                        forcast.CustomerPO = _item[12].ToString();
                                        forcast.ReliabilityDevision = "F";
                                        forcast.DeliveryDate = Convert.ToDateTime(_item[35].ToString().Substring(0, 4).Trim() + "-" + _item[35].ToString().Substring(4, 2).Trim() + "-" + _item[35].ToString().Substring(6, 2).Trim());
                                        forcast.Quantity = Convert.ToInt32(_item[32].ToString());
                                        forcast.Unit = "ST";
                                        forcast.DeliveryDestnationCode = materialTemp[2];
                                        forcast.PlngPeriod = "D";
                                        forcast.SAPCode = materialTemp[0];
                                        forcast.Insert();
                                    }
                                }
                                else
                                {
                                    boolStatusInsert = true;
                                }
                            }
                        }
                        else if (dt.Columns.Count == 30)
                        {
                            bool boolStatusInsert = false;
                            foreach (DataRow _item in dt.Rows)
                            {
                                if (boolStatusInsert)
                                {
                                    MyCompany.Models.AATForcastImport forcast = new MyCompany.Models.AATForcastImport();
                                    forcast.OrderBy = CustCode;
                                    forcast.DeliveryDestination = _item[8].ToString();
                                    forcast.CustomerMatCode = _item[11].ToString();
                                    string[] materialTemp = SharedBusinessRules.getMaterial(_item[11].ToString(), CustCode, _item[8].ToString(), "AAT").Split(':');
                                    forcast.PartsDevision = materialTemp[1];
                                    forcast.CustomerPO = _item[12].ToString();
                                    forcast.ReliabilityDevision = "F";
                                    forcast.DeliveryDate = Convert.ToDateTime(_item[28].ToString().Substring(0, 4).Trim() + "-" + _item[28].ToString().Substring(4, 2).Trim() + "-" + _item[28].ToString().Substring(6, 2).Trim());
                                    forcast.Quantity = Convert.ToInt32(_item[25].ToString());
                                    forcast.Unit = "ST";
                                    forcast.DeliveryDestnationCode = materialTemp[2];
                                    forcast.PlngPeriod = "D";
                                    forcast.SAPCode = materialTemp[0];
                                    forcast.Insert();
                                }
                                else
                                {
                                    boolStatusInsert = true;
                                }
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine( Server.MapPath("~/Files/"),"AATError.txt"), true))
                    {
                        sw.WriteLine(ex.Message);
                    }
                }
            }
        }
    }   
}
