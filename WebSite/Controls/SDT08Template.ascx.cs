using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Controls_SDT08Template : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        int lastMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        TextBox2.Text = DateTime.Now.AddDays(lastMonth).ToString("yyyy-MM-dd");
        if (!Page.IsPostBack)
        {
            ShowT08();
        }
    }

    private void ShowT08()
    {
        using (DataSetServiceTableAdapters.sp_Report_SDT08TableAdapter da = new DataSetServiceTableAdapters.sp_Report_SDT08TableAdapter())
        {
            DataSetService.sp_Report_SDT08DataTable dt = new DataSetService.sp_Report_SDT08DataTable();
            da.Fill(dt, Convert.ToDateTime(TextBox1.Text.Trim()), Convert.ToDateTime(TextBox2.Text.Trim()));
            
            ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("~/") + @"Reports\SDT08.rdlc";
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("SDT08", (System.Data.DataTable)dt));
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
        ShowT08();
    }
}
