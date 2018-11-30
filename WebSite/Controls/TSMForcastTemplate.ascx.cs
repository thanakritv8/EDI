using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using MyCompany.Rules;
using System.Text;



public partial class Controls_TSMForcastTemplate : System.Web.UI.UserControl
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
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string filename = System.IO.Path.GetFileName(AsyncFileUpload1.FileName);
        string fn = filename;
        filename = String.Format("TSM_{0}_ORDER_{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), filename);
        AsyncFileUpload1.SaveAs(Server.MapPath("~/Files/") + filename);
        filename = Server.MapPath("~/Files/") + filename;
        if (File.Exists(filename))
        {
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filename))
            {
                //using (SqlProcedure sp = new SqlProcedure("sp_TSM_Order_ClearData"))
                //{
                //    sp.ExecuteNonQuery();
                //}
                string[] strCol = { "DeliveryDestination", "CustomerMatCode", "CustomerPO", "Quantity", "DeliveryDate", "FromTo" };
                DataTable dt = new DataTable();
                foreach (string strItem in strCol)
                {
                    if (strItem == "Quantity")
                    {
                        dt.Columns.Add(strItem, typeof(int));
                    }
                    else
                    {
                        dt.Columns.Add(strItem);
                    }

                }
                while ((line = sr.ReadLine()) != null)
                {
                    string[] item = ParseCsvRow(line);
                    if (item.Length > 1 && (item[1].Trim() == "NEW" || item[1].Trim() == "RES"))
                    {
                        dt.Rows.Add(item[2].Trim(), item[3].Trim(), item[7].Trim(), Convert.ToInt32(item[9].Trim()), item[10].Trim(), "RTP:" + item[2].Trim());
                    }
                }
                DataTable dtTemp = dt.AsEnumerable()
                    .GroupBy(r => new { Col1 = r["DeliveryDestination"], Col2 = r["CustomerMatCode"], Col3 = r["CustomerPO"], Col4 = r["DeliveryDate"], Col5 = r["FromTo"] })
                    .Select(g =>
                    {
                        var row = dt.NewRow();
                        row["DeliveryDestination"] = g.Key.Col1;
                        row["CustomerMatCode"] = g.Key.Col2;
                        row["CustomerPO"] = g.Key.Col3;
                        row["Quantity"] = g.Sum(r => r.Field<int>("Quantity"));
                        row["DeliveryDate"] = g.Key.Col4;
                        row["FromTo"] = g.Key.Col5;
                        return row;
                    }).CopyToDataTable();
                string CustCode = "40102011";
                int i = 1;
                foreach (DataRow item in dtTemp.Rows)
                {
                    string[] dmy = Convert.ToString(item[4]).Split('/');
                    MyCompany.Models.TSMForcastImport Forcast = new MyCompany.Models.TSMForcastImport();
                    Forcast.OrderBy = CustCode;
                    Forcast.DeliveryDestination = Convert.ToString(item[0]);
                    Forcast.CustomerMatCode = Convert.ToString(item[1]);
                    Forcast.CustomerPO = Convert.ToString(item[2]);
                    Forcast.ReliabilityDevision = "P";
                    Forcast.Quantity = Convert.ToInt32(Convert.ToString(item[3]));
                    Forcast.Unit = "ST";
                    Forcast.PlngPeriod = "D";
                    Forcast.DeliveryDate = Convert.ToDateTime(dmy[0] + "-" + dmy[1] + "-20" + dmy[2]);
                    string[] materialTemp = SharedBusinessRules.getMaterial(Forcast.CustomerMatCode, CustCode, Forcast.DeliveryDestination, "TSM").Split(':');
                    if (materialTemp.Length > 1)
                    {
                        Forcast.SAPCode = materialTemp[0];
                        Forcast.PartsDevision = materialTemp[1];
                        Forcast.DeliveryDestinationCode = materialTemp[2];
                        Forcast.Key1 = materialTemp[3];
                        Forcast.Key2 = materialTemp[4];
                        Forcast.Key3 = materialTemp[5];
                    }
                    Forcast.FileName = fn;
                    Forcast.Insert();
                    i++;
                }
            }
        }
    }
}
