using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
    public partial class SharedBusinessRules : MyCompany.Data.BusinessRules
    {

        public SharedBusinessRules()
        {
            Context.Session["UserName"] = Context.User.Identity.Name.ToString();
        }

        public static string getMaterial(string CustMatCode, string OrderBy, string pc, string lc)
        {
            CustMatCode = CustMatCode.Replace(" ","");
            using (SqlProcedure sp = new SqlProcedure("sp_GetMaterial"))
            {
                sp.AddParameter("@CustomerItemNumber", CustMatCode);
                sp.AddParameter("@OrderBy", OrderBy);
                sp.AddParameter("@pc", pc);
                sp.AddParameter("@lc", lc);
                object sc = sp.ExecuteScalar();
                if (sc == null)
                {
                    return string.Empty;
                }
                else
                {
                    return sc.ToString();
                }                
            }
        }
        
        protected static void SetFormatField(ViewPage page)
        {
            for (int i = 0; i < page.Fields.Count; i++)
            {

                switch (page.Fields[i].Name)
                {
                    case "CreateDate":
                    case "UpdateDate":
                    case "DueDate":
                    case "PODate":
                    case "OrderDate":
                    case "ProductionDate":
                    case "ShipDate":
                    case "MoveDate":
                    case "DeliveryDate":
                    case "FirstMonthDate":
                    case "VaridityDateTo":
                    case "ValiditydateFrom":
                        page.Fields[i].FormatOnClient = true;
                        page.Fields[i].DataFormatString = "dd.MM.yyyy";
                        break;
                    case "PrintDate":
                    case "ReceiveDate":
                    case "LoadingDate":
                    case "SplitDate":
                    case "MergeDate":
                    case "PickingDate":
                    case "IssueDate":
                    case "RegisterDate":
                        page.Fields[i].FormatOnClient = true;
                        page.Fields[i].DataFormatString = "dd-MM-yyyy HH:mm";

                        break;
                    case "Qty":
                    case "ReceiveQty":
                    case "PickQty":
                    case "PendingQty":
                    case "POQty":
                    case "ScanQty":
                    case "PackRate":
                    case "PackPallet":
                    case "DeliveryQty":
                    case "OnhandQty":
                    case "ProductionQty":
                    case "Balance":
                    case "TotalPallet":
                    case "PackUnit":
                    case "DiffQty":
                    case "NGQty":
                    case "StdPack":
                        page.Fields[i].FormatOnClient = true;
                        page.Fields[i].DataFormatString = "N2";
                        break;
                    case "UnitWeight":
                    case "PackageWeight":
                        page.Fields[i].FormatOnClient = true;
                        page.Fields[i].DataFormatString = "N2";
                        break;
                    case "UnitPrice":
                    case "TotalAmt":
                    case "ExtendPrice":
                        page.Fields[i].FormatOnClient = true;
                        page.Fields[i].DataFormatString = "N2";
                        break;
                    // hide field
                    //case "CompanyId":
                    //case "CompanyCode":
                    //    page.Fields[i].Hidden = true;
                    //    break;
                    case "StartTime":
                    case "FinishTime":
                        page.Fields[i].DataFormatString = "{0:G}";
                        break;
                    case "AutoId":
                    case "CustomerId":
                        page.Fields[i].Hidden = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
