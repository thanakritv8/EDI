﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class OrdersBusinessRule : MyCompany.Rules.SharedBusinessRules
    {
        public override void ProcessPageRequest(PageRequest request, ViewPage page)
        {
            SharedBusinessRules.SetFormatField(page);
        }
    }
}
