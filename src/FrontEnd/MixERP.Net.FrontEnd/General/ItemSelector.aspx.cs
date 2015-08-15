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
using MixERP.Net.WebControls.ScrudFactory;
using System;
using System.Linq;
using System.Reflection;

namespace MixERP.Net.FrontEnd.General
{
    public partial class ItemSelector : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            using (ScrudItemSelector selector = new ScrudItemSelector())
            {
                selector.ID = "ScrudSelector";
                selector.TopPanelCssClass = "vpad16";
                selector.TopPanelTableCssClass = "valignmiddle";
                selector.ButtonCssClass = "ui positive button";
                selector.GridViewCssClass = "ui celled table segment";
                selector.GridViewPagerCssClass = "ui menu";
                selector.GridViewRowCssClass = "";
                selector.GridViewAlternateRowCssClass = "alt";
                selector.ResourceClassName = this.GetResourceClassName();
                selector.Catalog = AppUsers.GetCurrentUserDB();

                this.SelectorPlaceholder.Controls.Add(selector);
                this.OverridePath = this.GetOverridePath();
            }
        }

        private string GetOverridePath()
        {
            string path = this.Page.Request.QueryString["OverridePath"];

            if (!string.IsNullOrWhiteSpace(path))
            {
                return path;
            }

            return string.Empty;
        }

        private string GetResourceClassName()
        {
            string resourceClassName = this.Page.Request.QueryString["ResourceClassName"];

            if (!string.IsNullOrWhiteSpace(resourceClassName))
            {
                return resourceClassName;
            }

            return string.Empty;
        }
    }
}