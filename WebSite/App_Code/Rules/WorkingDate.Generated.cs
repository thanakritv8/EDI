using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class WorkingDateBusinessRule : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("WorkingDate", RowKind.New)]
        public void BuildNewWorkingDate()
        {
            UpdateFieldValue("StatusId", 1);
        }
    }
}
