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
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddCashTransactionDivField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel("&nbsp;"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlGenericControl toggleCheckBox = HtmlControlHelper.GetToggleCheckBox())
                {
                    toggleCheckBox.ID = "CashTransactionDiv";
                    using (HtmlInputCheckBox cashTransactionInputCheckBox = new HtmlInputCheckBox())
                    {
                        cashTransactionInputCheckBox.ID = "CashTransactionInputCheckBox";
                        cashTransactionInputCheckBox.Attributes.Add("checked", "checked");
                        toggleCheckBox.Controls.Add(cashTransactionInputCheckBox);
                    }

                    using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.CashTransaction))
                    {
                        toggleCheckBox.Controls.Add(label);
                    }

                    field.Controls.Add(toggleCheckBox);
                }

                container.Controls.Add(field);
            }
        }
    }
}