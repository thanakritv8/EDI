using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MyCompany.Data;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public string Customer_Validate(string CustCode)
    {
        using (SqlText sql = new SqlText(String.Format("select count(1) from Customer where Code = '{0}'", CustCode)))
        {
            string result = sql.ExecuteScalar().ToString();
            return result;
        }
    }

    [WebMethod]
    public string getUnitCode(string MatCode, string CustCode)
    {
        using (SqlText sql = new SqlText(String.Format("select top(1) isnull(UnitCode,'') from MaterialNumber where CustomerItemNumber = '{0}' and SoldtoParty = '{1}'", CustCode, MatCode)))
        {
            string result = sql.ExecuteScalar().ToString();
            return result;
        }
    }

    //[WebMethod]
    //public string ManualKeyIn(string Flag, 

}
