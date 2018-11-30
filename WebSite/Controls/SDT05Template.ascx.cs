using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Controls_SDT05Template : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("~/") + @"Reports\SDT05.rdlc";
            //ReportViewer1.LocalReport.DataSources.Clear();
            //ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("SDT05", new DataTable()));
            //ReportViewer1.LocalReport.Refresh();
            ShowT05();
        }
    }

    private void ShowT05()
    {
        using (DataSetServiceTableAdapters.sp_Report_SDT05TableAdapter da = new DataSetServiceTableAdapters.sp_Report_SDT05TableAdapter())
        {
            DataSetService.sp_Report_SDT05DataTable dt = new DataSetService.sp_Report_SDT05DataTable();
            da.Fill(dt, Convert.ToDateTime(TextBox1.Text.Trim()), Convert.ToDateTime(TextBox2.Text.Trim()));
            var dv = dt.DefaultView.ToTable(true, "CustomerMatCode", "DeliveryDestination");
            foreach (DataRow _Item in dv.Rows)
            {
                string CustomerMatCode = _Item["CustomerMatCode"].ToString();
                string DeliveryDestination = _Item["DeliveryDestination"].ToString();
                for (DateTime _dmy = Convert.ToDateTime(TextBox1.Text.Trim()); _dmy <= Convert.ToDateTime(TextBox2.Text.Trim()); _dmy = _dmy.AddDays(1))
                {
                    DataRow[] dr = dt.Select("CustomerMatCode = '" + CustomerMatCode + "' AND DeliveryDestination = '" + DeliveryDestination + "'");
                    if (dr.Length > 0)
                    {
                        DataRow[] drCheckDate = dt.Select("DeliveryDate = '" + _dmy.ToString() + "' AND CustomerMatCode = '" + CustomerMatCode + "' AND DeliveryDestination = '" + DeliveryDestination + "'");
                        if (drCheckDate.Length == 0)
                        {
                            dt.Rows.Add(dr[0]["Orderby"], dr[0]["DeliveryDestnationCode"], dr[0]["DeliveryDestination"], dr[0]["CustomerMatCode"], 1, "", "", "", "", "P", _dmy, 0, dr[0]["Unit"], dr[0]["PlngPeriod"], dr[0]["SAPCode"], dr[0]["CustomerId"], "", dr[0]["CreateDate"], "", dr[0]["UpdateDate"]);
                        }
                    }
                }
            }

            ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("~/") + @"Reports\SDT05.rdlc";
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("SDT05", (System.Data.DataTable)dt));
            ReportViewer1.LocalReport.Refresh();
        }
    }

    protected void btnExecute_Click(object sender, EventArgs e)
    {
        ExecuteReport();
    }

    private void DefaultDate()
    {
        //txtStartDate.Text = FirstDayOfMonthFromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
        //txtEndDate.Text = LastDayOfMonthFromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
    }

    public DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
    {
        return new DateTime(dateTime.Year, dateTime.Month, 1);
    }
    public DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
    {
        DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
        return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
    }

    private void ExecuteReport()
    {
        ShowT05();
    }
}
