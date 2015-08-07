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

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class WidgetManager : WebService
    {
        [WebMethod]
        public void RemoveWidget(string group, string widget)
        {
            Data.Core.Widget.RemoveWidget(AppUsers.GetCurrentUserDB(), group, widget);
        }

        [WebMethod]
        public void AddWidget(int order, string group, string widget)
        {
            Data.Core.Widget.AddWidget(AppUsers.GetCurrentUserDB(), order, group, widget);
        }

        [WebMethod]
        public void OrderWidgets(List<WidgetSetup> widgets)
        {
            Data.Core.Widget.OrderWidgets(AppUsers.GetCurrentUserDB(), widgets);
        }

    }
}