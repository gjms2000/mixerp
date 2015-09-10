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

using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddDateTextBoxField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ValueDate))
                {
                    field.Controls.Add(label);
                }

                this.dateTextBox = new DateTextBox();
                this.dateTextBox.ID = "DateTextBox";
                this.dateTextBox.OfficeId = this.OfficeId;
                this.dateTextBox.Mode = FrequencyType.Today;
                this.dateTextBox.CssClass = "date";
                this.dateTextBox.Catalog = this.Catalog;
                this.dateTextBox.OfficeId = this.OfficeId;

                field.Controls.Add(this.dateTextBox);
                container.Controls.Add(field);
            }
        }
    }
}