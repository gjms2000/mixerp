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

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddTopFormControls(HtmlGenericControl container)
        {
            this.AddDateTextBoxField(container);

            if (this.ShowStore)
            {
                AddStoreSelectField(container);
            }

            this.AddPartyCodeInputTextField(container);
            AddPartySelectField(container);

            if (this.ShowPriceTypes)
            {
                AddPriceTypeSelectField(container);
            }

            this.AddReferenceNumberInputTextField(container);

            if (this.ShowTransactionType)
            {
                this.AddCashTransactionDivField(container);
            }

            if (this.ShowPaymentTerms)
            {
                this.AddPaymentTermSelectField(container);
            }
        }

        private int CountTopFormControls()
        {
            return 4
                   + (this.ShowStore ? 1 : 0)
                   + (this.ShowPriceTypes ? 1 : 0)
                   + (this.ShowTransactionType ? 1 : 0)
                   + (this.ShowPaymentTerms ? 1 : 0);
        }
    }
}