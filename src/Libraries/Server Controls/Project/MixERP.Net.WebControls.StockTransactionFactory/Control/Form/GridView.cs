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
using MixERP.Net.Entities.Models.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.i18n;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateGrid(Control container)
        {
            using (HtmlGenericControl div = new HtmlGenericControl("div"))
            {
                div.Attributes.Add("style", "width:100%;overflow:auto;");
                div.Attributes.Add("class", "ui form vpad16");

                using (Table productGridView = new Table())
                {
                    productGridView.ID = "ProductGridView";
                    productGridView.CssClass = "ui table";
                    productGridView.Style.Value = ConfigurationHelper.GetStockTransactionFactoryParameter("GridStyle");

                    CreateHeaderRow(productGridView);
                    this.CreateFooterRow(productGridView);

                    div.Controls.Add(productGridView);
                }

                container.Controls.Add(div);
            }
        }

        private void BindGridView()
        {
            Collection<ProductDetail> table = this.GetTable();

            if (table.Count > 0)
            {
                List<string[]> rowData = new List<string[]>();

                foreach (ProductDetail row in table)
                {
                    string[] colData = new string[12];

                    colData[0] = row.ItemCode;
                    colData[1] = row.ItemName;
                    colData[2] = row.Quantity.ToString(CultureManager.GetCurrent());
                    colData[3] = row.Unit;
                    colData[4] = row.Price.ToString(CultureManager.GetCurrent());
                    colData[5] = row.Amount.ToString(CultureManager.GetCurrent());
                    colData[6] = row.Discount.ToString(CultureManager.GetCurrent());
                    colData[7] = row.ShippingCharge.ToString(CultureManager.GetCurrent());
                    colData[8] = row.Subtotal.ToString(CultureManager.GetCurrent());
                    colData[9] = row.TaxCode.ToString(CultureManager.GetCurrent());
                    colData[10] = row.Tax.ToString(CultureManager.GetCurrent());
                    colData[11] = row.Total.ToString(CultureManager.GetCurrent());

                    rowData.Add(colData);
                }

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string data = serializer.Serialize(rowData);

                this.productGridViewDataHidden.Value = data;
            }
        }

    }
}