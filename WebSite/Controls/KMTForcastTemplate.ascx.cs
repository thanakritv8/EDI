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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data.OleDb;


public partial class Controls_KMTForcastTemplate : System.Web.UI.UserControl
{


    protected void Page_Load(object sender, EventArgs e)
    {
    }

    private void ExcelToCSVCoversion(string sourceFile, string targetFile)
    {
        Excel.Application rawData = new Excel.Application();

        try
        {
            Excel.Workbook workbook = rawData.Workbooks.Open(sourceFile);
            Excel.Worksheet ws = (Excel.Worksheet)workbook.Sheets[1];
            ws.SaveAs(targetFile, Excel.XlFileFormat.xlCSV);
            Marshal.ReleaseComObject(ws);
            System.Diagnostics.Debug.WriteLine("TEST"); 
        }
        catch(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Server.MapPath("~/Files/"), "KMTError.txt"), true))
            {
                sw.WriteLine(ex.Message);
            }
        }

        finally
        {
            try
            {
                rawData.DisplayAlerts = false;
                rawData.Quit();
                Marshal.ReleaseComObject(rawData);
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Server.MapPath("~/Files/"), "KMTError.txt"), true))
                {
                    sw.WriteLine(ex.Message);
                }
            }
            
        }
        
        
    }

    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("TSM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);
        filename = Server.MapPath("~/Files/") + filename;
        string extfile = Path.GetExtension(filename);
        string fileCsv = filename.Replace(extfile, ".csv");
        ExcelToCSVCoversion(filename, fileCsv);
        if (File.Exists(fileCsv))
        {
            DataTable dt = new DataTable();
            var connString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""", Path.GetDirectoryName(filename));
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                var query = "SELECT * FROM [" + Path.GetFileName(fileCsv) + "]";
                using (var adapter = new OleDbDataAdapter(query, con))
                {
                    adapter.Fill(dt);
                    if (dt.Columns.Count == 18)
                    {
                        DataTable dtTemp = dt.AsEnumerable()
                        .GroupBy(r => new { Col1 = r["PLACE"], Col2 = r["P-NO"], Col3 = r["DUE"]})
                        .Select(g =>
                        {
                            var row = dt.NewRow();
                            row["PLACE"] = g.Key.Col1;
                            row["P-NO"] = g.Key.Col2;
                            row["QTY"] = g.Sum(r => r.Field<int>("QTY"));
                            row["DUE"] = g.Key.Col3;
                            return row;
                        }).CopyToDataTable();
                        string CustCode = "40104011";
                        foreach (DataRow item in dtTemp.Rows)
                        {
                            MyCompany.Models.KMTForcastImport Forcast = new MyCompany.Models.KMTForcastImport();
                            Forcast.OrderBy = CustCode;
                            Forcast.DeliveryDestination = item[5].ToString();
                            string[] arrCus = item[1].ToString().Split('-');
                            Forcast.CustomerMatCode = arrCus[0].ToString().Substring(arrCus[0].Length - 5) + "-" + arrCus[1].Substring(0,4);
                            string[] materialTemp = SharedBusinessRules.getMaterial(Forcast.CustomerMatCode, Forcast.OrderBy, item[5].ToString(), "KMT").Split(':');
                            if (materialTemp.Length > 1)
                            {
                                Forcast.SAPCode = materialTemp[0];
                                if (materialTemp[1] == "1A")
                                {
                                    Forcast.PartsDevision = "1";
                                }
                                else if (materialTemp[1] == "1B")
                                {
                                    Forcast.PartsDevision = "2";
                                }
                                else
                                {
                                    Forcast.PartsDevision = materialTemp[1];
                                }

                                Forcast.DeliveryDestinationCode = materialTemp[2];
                                Forcast.Key1 = materialTemp[3];
                                Forcast.Key2 = materialTemp[4];
                                Forcast.Key3 = materialTemp[5];
                            }
                            Forcast.CustomerPO = "";
                            Forcast.ReliabilityDevision = "P";
                            Forcast.Unit = "ST";
                            Forcast.PlngPeriod = "D";
                            Forcast.DeliveryDate = Convert.ToDateTime(item[4]);
                            Forcast.Quantity = Convert.ToInt32(item[7].ToString());
                            Forcast.FileName = fn;
                            Forcast.Insert();
                        }
                    }
                    else if(dt.Columns.Count == 16)
                    {
                        DataTable dtTemp = dt.AsEnumerable()
                        .GroupBy(r => new { Col1 = r["RCV PLACE"], Col2 = r["ITEMNO"], Col3 = r["DUE"] })
                        .Select(g =>
                        {
                            var row = dt.NewRow();
                            row["RCV PLACE"] = g.Key.Col1;
                            row["ITEMNO"] = g.Key.Col2;
                            row["QTY"] = g.Sum(r => r.Field<int>("QTY"));
                            row["DUE"] = g.Key.Col3;
                            return row;
                        }).CopyToDataTable();
                        string CustCode = "40104011";
                        foreach (DataRow item in dtTemp.Rows)
                        {
                            MyCompany.Models.KMTForcastImport Forcast = new MyCompany.Models.KMTForcastImport();
                            Forcast.OrderBy = CustCode;
                            Forcast.DeliveryDestination = item[7].ToString();
                            string[] arrCus = item[1].ToString().Split('-');
                            Forcast.CustomerMatCode = arrCus[0].ToString().Substring(arrCus[0].Length - 5) + "-" + arrCus[1].Substring(0, 4);
                            string[] materialTemp = SharedBusinessRules.getMaterial(Forcast.CustomerMatCode, Forcast.OrderBy, item[7].ToString(), "KMT").Split(':');
                            if (materialTemp.Length > 1)
                            {
                                Forcast.SAPCode = materialTemp[0];
                                if (materialTemp[1] == "1A")
                                {
                                    Forcast.PartsDevision = "1";
                                }
                                else if (materialTemp[1] == "1B")
                                {
                                    Forcast.PartsDevision = "2";
                                }
                                else
                                {
                                    Forcast.PartsDevision = materialTemp[1];
                                }

                                Forcast.DeliveryDestinationCode = materialTemp[2];
                                Forcast.Key1 = materialTemp[3];
                                Forcast.Key2 = materialTemp[4];
                                Forcast.Key3 = materialTemp[5];
                            }
                            Forcast.CustomerPO = "";
                            Forcast.ReliabilityDevision = "F";
                            Forcast.Unit = "ST";
                            Forcast.PlngPeriod = "D";
                            Forcast.DeliveryDate = Convert.ToDateTime(item[5]);
                            Forcast.Quantity = Convert.ToInt32(item[6].ToString());
                            Forcast.FileName = fn;
                            Forcast.Insert();
                        }
                    }
                }
            }
        }
    }
}