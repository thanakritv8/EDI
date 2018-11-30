using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class HATCOrderImportBusinessRule : MyCompany.Rules.SharedBusinessRules
    {
        public override void ProcessPageRequest(PageRequest request, ViewPage page)
        {
            SharedBusinessRules.SetFormatField(page);
        }
        protected override void ExecuteAction(ActionArgs args, ActionResult result)
        {
            if (args.CommandName.Equals("Custom") && args.CommandArgument.Equals("Execute"))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_HATC_Order_Execute"))
                {
                    sp.Command.CommandTimeout = 60 * 5;
                    sp.AddParameter("@Username", Context.User.Identity.Name);
                    if (sp.ExecuteScalar().ToString().Equals("0"))
                    {
                        result.ShowAlert("Invalid Material Number");
                        result.Refresh();
                    }
                    else
                    {
                        result.ShowAlert("Execute OK");
                        result.Refresh();
                    }
                }
            }
            else if (args.CommandName.Equals("Custom") && args.CommandArgument.Equals("ClearData"))
            {
                using (SqlProcedure sp = new SqlProcedure("sp_HATC_Order_ClearData"))
                {
                    sp.ExecuteNonQuery();
                    result.Refresh();
                }
            }
        }
    }
}
