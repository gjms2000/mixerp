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
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Collections.Generic;

namespace MixERP.Net.Core.Modules.Inventory.Setup
{
    public partial class ItemGroups : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Scrud scrud = new Scrud())
            {
                scrud.KeyColumn = "item_group_id";
                scrud.TableSchema = "core";
                scrud.Table = "item_groups";
                scrud.ViewSchema = "core";
                scrud.View = "item_group_scrud_view";
                scrud.DisplayFields = GetDisplayFields();
                scrud.DisplayViews = GetDisplayViews();
                scrud.UseLocalColumnInDisplayViews = true;
                scrud.UseDisplayViewsAsParents = true;

                scrud.Text = Titles.ItemGroups;
                this.ScrudPlaceholder.Controls.Add(scrud);
            }
        }

        private static string GetDisplayFields()
        {
            List<string> displayFields = new List<string>();

            string accountDisplayField = DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "AccountDisplayField");

            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.parent_item_group_id", DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "ItemGroupDisplayField"));
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.sales_tax_id", DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "SalesTaxDisplayField"));
            ScrudHelper.AddDisplayField(displayFields, "core.accounts.account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.sales_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.sales_discount_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.sales_return_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.purchase_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.purchase_discount_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.inventory_account_id", accountDisplayField);
            ScrudHelper.AddDisplayField(displayFields, "core.item_groups.cost_of_goods_sold_account_id", accountDisplayField);


            return string.Join(",", displayFields);
        }

        private static string GetDisplayViews()
        {
            List<string> displayViews = new List<string>();

            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.parent_item_group_id", "core.item_group_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.sales_account_id", "core.revenue_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.sales_discount_account_id", "core.expenses_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.sales_return_account_id", "core.sales_return_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.purchase_account_id", "core.purchase_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.purchase_discount_account_id", "core.discount_received_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.inventory_account_id", "core.inventory_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.cost_of_goods_sold_account_id", "core.cost_of_sales_account_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.item_groups.sales_tax_id", "core.sales_tax_scrud_view");

            return string.Join(",", displayViews);
        }
    }
}