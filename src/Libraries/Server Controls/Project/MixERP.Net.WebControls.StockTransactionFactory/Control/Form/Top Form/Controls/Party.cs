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
        private void AddPartyCodeInputTextField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.SelectParty))
                {
                    field.Controls.Add(label);
                }

                this.partyCodeInputText = new HtmlInputText();
                this.partyCodeInputText.ID = "PartyCodeInputText";
                this.partyCodeInputText.Attributes.Add("title", "F2");

                field.Controls.Add(this.partyCodeInputText);
                container.Controls.Add(field);
            }
        }

        private static void AddPartySelectField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel("&nbsp;"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlSelect partySelect = new HtmlSelect())
                {
                    partySelect.ID = "PartySelect";
                    partySelect.Attributes.Add("title", "F2");

                    field.Controls.Add(partySelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}