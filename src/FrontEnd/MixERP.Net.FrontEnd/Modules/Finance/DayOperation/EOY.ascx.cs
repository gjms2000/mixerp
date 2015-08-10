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

using System;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.Finance.DayOperation
{
    public partial class EOY : MixERPUserControl
    {
        public override AccessLevel AccessLevel
        {
            get { return AccessLevel.AdminOnly; }
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            int inStack = TransactionGovernor.Verification.Stack.CountItemsInVerificationStack(catalog, officeId);
            this.EOYPanel.Visible = inStack == 0;
            this.MessagePanel.Visible = !this.EOYPanel.Visible;

            this.SetOverrideUrl();
        }

        private void SetOverrideUrl()
        {
            this.OverridePath = "/Modules/Finance/EODOperation.mix";        
        }
    }
}