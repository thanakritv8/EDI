using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MyCompany.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
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

    [WebMethod]
    public string cbPlantCode(string strCondition)
    {
        System.Collections.ArrayList receiverList = new System.Collections.ArrayList();
        using (SqlText sql = new SqlText(String.Format("select distinct(PlantCode) from Customer where Code like '{0}%' and PlantCode is not null", strCondition)))
        {
            System.Data.Common.DbDataReader readerSender = sql.ExecuteReader();
            while (readerSender.Read())
            {
                receiverList.Add(readerSender["PlantCode"].ToString());
            }
            readerSender.Close();
            readerSender.Dispose();
        }
        MN[] l = new MN[receiverList.Count];
        for (int i = 0; i <= receiverList.Count - 1; i++)
        {
            l[i] = new MN();
            l[i].strItem = receiverList[i].ToString();
        }
        return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(l);
    }

    [WebMethod]
    public string cbMatCode(string strCondition)
    {
        string[] strArr = strCondition.Split(':');
        System.Collections.ArrayList receiverList = new System.Collections.ArrayList();
        using (SqlText sql = new SqlText(String.Format("select m.customerItemNumber from MaterialNumber as m join Customer as c on m.ShiptoParty = c.Code where c.PlantCode = '{1}' and shiptoParty like '{0}%'", strArr[0], strArr[1])))
        {
            System.Data.Common.DbDataReader readerSender = sql.ExecuteReader();
            while (readerSender.Read())
            {
                receiverList.Add(readerSender["customerItemNumber"].ToString());
            }
            readerSender.Close();
            readerSender.Dispose();
        }
        MN[] l = new MN[receiverList.Count];
        for (int i = 0; i <= receiverList.Count - 1; i++)
        {
            l[i] = new MN();
            l[i].strItem = receiverList[i].ToString();
        }
        return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(l);
    }

    [WebMethod]
    public string ShowMatInText(string strCondition)
    {
        string[] strArr = strCondition.Split(':');
        System.Collections.ArrayList mass = new System.Collections.ArrayList();
        System.Collections.ArrayList key1 = new System.Collections.ArrayList();
        System.Collections.ArrayList key2 = new System.Collections.ArrayList();
        System.Collections.ArrayList key3 = new System.Collections.ArrayList();
        using (SqlText sql = new SqlText(String.Format("select m.MassPartsIDFlag, m.ExpansionKey1, m.ExpansionKey2, m.ExpansionKey3 from MaterialNumber as m join Customer as c on m.ShiptoParty = c.Code where c.PlantCode = '{1}' and shiptoParty like '{0}%' and m.customerItemNumber = '{2}'", strArr[0], strArr[1], strArr[2])))
        {
            System.Data.Common.DbDataReader readerSender = sql.ExecuteReader();
            while (readerSender.Read())
            {
                mass.Add(readerSender["MassPartsIDFlag"].ToString());
                key1.Add(readerSender["ExpansionKey1"].ToString());
                key2.Add(readerSender["ExpansionKey2"].ToString());
                key3.Add(readerSender["ExpansionKey3"].ToString());
            }
            readerSender.Close();
            readerSender.Dispose();
        }
        MN[] l = new MN[mass.Count];
        for (int i = 0; i <= mass.Count - 1; i++)
        {
            l[i] = new MN();
            l[i].MassPartsIDFlag = mass[i].ToString();
            l[i].ExpansionKey1 = key1[i].ToString();
            l[i].ExpansionKey2 = key2[i].ToString();
            l[i].ExpansionKey3 = key3[i].ToString();
        }
        return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(l);
    }

}

public class MN
{
    public string strItem { set; get; }
    public string MassPartsIDFlag { set; get; }
    public string ExpansionKey1 { set; get; }
    public string ExpansionKey2 { set; get; }
    public string ExpansionKey3 { set; get; }
}
