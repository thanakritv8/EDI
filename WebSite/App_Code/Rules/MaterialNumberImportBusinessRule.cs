using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class MaterialNumberImportBusinessRule : MyCompany.Rules.SharedBusinessRules
    {
        public string UserName
        {
            get { return SharedBusinessRules.UserName; }
        }

        public override void ProcessPageRequest(PageRequest request, ViewPage page)
        {
            Context.Session["UserName"] = SharedBusinessRules.UserName;
            SharedBusinessRules.SetFormatField(page);
        }
    }
}
