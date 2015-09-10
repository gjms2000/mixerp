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

using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private readonly string[] numbers = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

        private void CreateTopFormPanel(Control container)
        {
            using (HtmlGenericControl segment = HtmlControlHelper.GetSegment())
            {
                using (HtmlGenericControl form = new HtmlGenericControl("div"))
                {
                    form.Attributes.Add("class", "ui stackable form");

                    var totalFields = this.CountTopFormControls();

                    using (HtmlGenericControl fields = HtmlControlHelper.GetFields(this.numbers[totalFields] + " fields"))
                    {
                        this.AddTopFormControls(fields);

                        form.Controls.Add(fields);
                    }

                    segment.Controls.Add(form);

                }

                container.Controls.Add(segment);
            }


            using (HtmlGenericControl form = HtmlControlHelper.GetForm())
            {
                using (HtmlGenericControl fields = HtmlControlHelper.GetFields("two fields"))
                {
                    if (this.ShowShippingInformation)
                    {
                        AddShippingAddressCompositeField(fields);
                    }

                    if (this.Book == TranBook.Sales && this.ShowSalesType)
                    {
                        this.AddSalesTypeField(fields);
                    }

                    form.Controls.Add(fields);
                }

                container.Controls.Add(form);
            }
        }
    }
}