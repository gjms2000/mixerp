/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MixERP.Net.Common.Extensions;

namespace MixERP.Net.Core.Modules.Sales.Reports
{
    public partial class SalesByOfficeFrame : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@office_id", AppUsers.GetCurrent().View.OfficeId.ToInt() ));

            using (WebReport report = new WebReport())
            {
                report.AutoInitialize = true;
                report.NoHeader = true;
                report.AddParameterToCollection (list);
                report.Path = "~/Modules/Sales/Reports/Source/SalesByOffice.xml";
                this.Controls.Add(report);
            }
        }
    }
}