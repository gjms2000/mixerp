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
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.ScrudFactory.Data;
using MixERP.Net.WebControls.ScrudFactory.Helpers;

namespace MixERP.Net.WebControls.ScrudFactory.Controls.ListControls
{
    internal static class ScrudDropDownList
    {
        internal static void AddDropDownList(string catalog, HtmlTable container, string resourcePrefix,
            string itemSelectorPath, string currentSchema, string currentTable, string columnName, string label, string description,
            bool isNullable, string targetSchema, string targetTable,
            string targetColumn, string defaultValue, string displayFields, string displayViews,
            bool useDisplayViewsAsParent, string selectedValues, string errorCssClass, bool disabled,
            bool useLocalColumnInDisplayViews)
        {
            if (string.IsNullOrWhiteSpace(label))
            {
                label = ScrudLocalizationHelper.GetResourceString(resourcePrefix, columnName);
            }

            using (DropDownList dropDownList = GetDropDownList(columnName + "_dropdownlist"))
            {
                if (!string.IsNullOrWhiteSpace(description))
                {
                    dropDownList.CssClass += " activating element";
                    dropDownList.Attributes.Add("data-content", description);
                }

                if (disabled)
                {
                    dropDownList.Attributes.Add("disabled", "disabled");
                }

                using (
                    DataTable table = GetTable(catalog, targetSchema, targetTable, targetColumn,
                        currentSchema, currentTable, columnName, displayViews, useDisplayViewsAsParent,
                        useLocalColumnInDisplayViews))
                {
                    SetDisplayFields(catalog, dropDownList, table, targetSchema, targetTable, targetColumn,
                        currentSchema, currentTable, columnName, displayFields,
                        useLocalColumnInDisplayViews);

                    using (
                        HtmlAnchor itemSelectorAnchor = GetItemSelector(catalog, dropDownList.ClientID, itemSelectorPath,
                            targetSchema, targetTable, targetColumn, currentSchema,
                            currentTable, columnName, displayViews, resourcePrefix, label,
                            useLocalColumnInDisplayViews))
                    {
                        if (disabled)
                        {
                            itemSelectorAnchor.Attributes.Add("style", "pointer-events:none;");
                        }

                        SetSelectedValue(catalog, dropDownList, targetSchema, targetTable, targetColumn,
                            currentSchema, currentTable, columnName, defaultValue, selectedValues,
                            useLocalColumnInDisplayViews);

                        if (isNullable)
                        {
                            dropDownList.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                            ScrudFactoryHelper.AddDropDownList(container, label, dropDownList, itemSelectorAnchor, null);
                        }
                        else
                        {
                            RequiredFieldValidator required = ScrudFactoryHelper.GetRequiredFieldValidator(
                                dropDownList, errorCssClass);
                            ScrudFactoryHelper.AddDropDownList(container, label + Labels.RequiredFieldIndicator,
                                dropDownList, itemSelectorAnchor, required);
                        }
                    }
                }
            }
        }

        private static DropDownList GetDropDownList(string id)
        {
            using (DropDownList dropDownList = new DropDownList())
            {
                dropDownList.ID = id;
                dropDownList.ClientIDMode = ClientIDMode.Static;

                return dropDownList;
            }
        }

        private static string GetExpressionValue(string catalog, string expressions, string targetSchema,
            string targetTable, string targetColumn, string currentSchema, string currentTable, string currentColumn,
            bool useLocalColumnInDisplayViews)
        {
            if (new[] {expressions, targetSchema, targetTable, targetColumn}.AnyNullOrWhitespace())
            {
                return string.Empty;
            }

            //Fully qualified relation name (PostgreSQL Terminology).
            string relation = targetSchema + "." + targetTable + "." + targetColumn;

            if (useLocalColumnInDisplayViews)
            {
                relation = currentSchema + "." + currentTable + "." + currentColumn;
            }

            char itemSeparator = char.Parse(DbConfig.GetScrudParameter(catalog, "ItemSeparator"));
            string expressionSeparator = DbConfig.GetScrudParameter(catalog, "ExpressionSeparator");

            foreach (string item in expressions.Split(itemSeparator))
            {
                //First, trim the field to remove whitespace.
                string expression = item.Trim();

                //Check whether this expression matches with the fully qualified column name.
                if (expression.StartsWith(relation, StringComparison.OrdinalIgnoreCase))
                {
                    //Remove the column name and expression separator and return the actual expression value.
                    return expression.Replace(relation + expressionSeparator, string.Empty);
                }
                //Probably that was not the field we were looking for.
            }

            return string.Empty;
        }

        /// <summary>
        ///     Creates item selector html anchor which basically is an extender of the control. The
        ///     extender is an html image button which, when clicked, will open a popup window which
        ///     allows selection, filtering, search, etc. on the target table.
        /// </summary>
        /// <param name="catalog"></param>
        /// <param name="associatedControlId">ClientID of the DropDownList control to which this control is associated to.</param>
        /// <param name="itemSelectorPath">Item Selector Target Url</param>
        /// <param name="targetTableSchema">Target Table Schema</param>
        /// <param name="targetTableName">Target Table</param>
        /// <param name="targetTableColumn"></param>
        /// <param name="currentColumn"></param>
        /// <param name="displayViews">Scrud DisplayView Expressions</param>
        /// <param name="resourceClassName">The resource class name containing localization.</param>
        /// <param name="columnNameLocalized">Localized name of the column to which item selector is bound to.</param>
        /// <param name="currentSchema"></param>
        /// <param name="currentTable"></param>
        /// <param name="useLocalColumnInDisplayViews"></param>
        /// <returns></returns>
        private static HtmlAnchor GetItemSelector(string catalog, string associatedControlId, string itemSelectorPath,
            string targetTableSchema, string targetTableName, string targetTableColumn, string currentSchema,
            string currentTable, string currentColumn, string displayViews, string resourceClassName,
            string columnNameLocalized, bool useLocalColumnInDisplayViews)
        {
            if (string.IsNullOrWhiteSpace(displayViews))
            {
                return null;
            }

            using (HtmlAnchor itemSelectorAnchor = new HtmlAnchor())
            {
                //string relation = string.Empty;

                //Get the expression value of display view from comma separated list of expressions.
                //The expression must be a valid fully qualified table or view name.
                string viewRelation = GetExpressionValue(catalog, displayViews, targetTableSchema, targetTableName,
                    targetTableColumn, currentSchema, currentTable, currentColumn, useLocalColumnInDisplayViews);

                string schema = viewRelation.Split('.').First();
                string view = viewRelation.Split('.').Last();
                var currentPage = HttpContext.Current.Request.Url.AbsolutePath;

                //Sanitize the schema and the view
                schema = Sanitizer.SanitizeIdentifierName(schema);
                view = Sanitizer.SanitizeIdentifierName(view);

                if (string.IsNullOrWhiteSpace(schema) || string.IsNullOrWhiteSpace(view))
                {
                    return null;
                }

                itemSelectorAnchor.Attributes["class"] = DbConfig.GetScrudParameter(catalog,
                    "ItemSelectorAnchorCssClass");

                itemSelectorAnchor.Attributes.Add("role", "item-selector");

                itemSelectorAnchor.Attributes.Add("tabindex", "10000");
                itemSelectorAnchor.Attributes.Add("data-title", columnNameLocalized);

                itemSelectorAnchor.HRef = itemSelectorPath + "?Schema=" + schema + "&View=" + view +
                                          "&AssociatedControlId=" + associatedControlId + "&ResourceClassName=" +
                                          resourceClassName + "&OverridePath=" + currentPage;

                return itemSelectorAnchor;
            }
        }

        private static DataTable GetTable(string catalog, string targetSchema, string targetTableName,
            string targetColumn, string currentTableSchema, string currentTableName, string currentColumn,
            string displayViews, bool useDisplayViewsAsParent, bool useLocalColumnInDisplayViews)
        {
            if (useDisplayViewsAsParent)
            {
                string viewRelation = GetExpressionValue(catalog, displayViews, targetSchema, targetTableName,
                    targetColumn, currentTableSchema, currentTableName, currentColumn, useLocalColumnInDisplayViews);

                string schema = viewRelation.Split('.').First();
                string view = viewRelation.Split('.').Last();

                //Sanitize the schema and the view
                schema = Sanitizer.SanitizeIdentifierName(schema);
                view = Sanitizer.SanitizeIdentifierName(view);

                if (string.IsNullOrWhiteSpace(schema) || string.IsNullOrWhiteSpace(view))
                {
                    return FormHelper.GetTable(catalog, targetSchema, targetTableName, "1");
                }

                return FormHelper.GetTable(catalog, schema, view, "1");
            }

            return FormHelper.GetTable(catalog, targetSchema, targetTableName, "1");
        }

        private static void SetDisplayFields(string catalog, DropDownList dropDownList, DataTable table,
            string targetSchema, string targetTable, string targetColumn, string currentSchema, string currentTable,
            string currentColumn, string displayFields, bool useLocalColumnInDisplayViews)
        {
            //See DisplayFields Property for more information.

            if (table.Rows.Count > 0)
            {
                //Get the expression value of display field from comma separated list of expressions.
                //The expression can be either the column name or a column expression.
                string columnOrExpression = GetExpressionValue(catalog, displayFields, targetSchema, targetTable,
                    targetColumn, currentSchema, currentTable, currentColumn, useLocalColumnInDisplayViews);

                //Let's check whether the display field expression really exists.
                //If it does not exist, it is probably an expression column.
                if (!table.Columns.Contains(columnOrExpression))
                {
                    //Add the expression as a new column in the datatable.
                    table.Columns.Add("DataTextField", typeof (string), columnOrExpression);
                    columnOrExpression = "DataTextField";
                }

                dropDownList.DataSource = table;
                dropDownList.DataValueField = targetColumn;
                dropDownList.DataTextField = columnOrExpression;
                dropDownList.DataBind();
            }
        }

        private static void SetSelectedValue(string catalog, DropDownList dropDownList, string targetSchema,
            string targetTable, string targetColumn, string currentSchema, string currentTable, string currentColumn,
            string postbackValue, string selectedValueExpressions, bool useLocalColumnInDisplayViews)
        {
            string selectedItemValue = string.Empty;

            if (dropDownList == null || new[] {targetSchema, targetTable, targetColumn}.AnyNullOrWhitespace())
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(postbackValue) && string.IsNullOrWhiteSpace(selectedValueExpressions))
            {
                return;
            }

            //If the post back contains a value, skip finding value from expressions.
            if (!string.IsNullOrWhiteSpace(postbackValue))
            {
                selectedItemValue = postbackValue;
            }
            else
            {
                //Find value from expressions.
                if (!string.IsNullOrWhiteSpace(selectedValueExpressions))
                {
                    string value = GetExpressionValue(catalog, selectedValueExpressions, targetSchema, targetTable,
                        targetColumn, currentSchema, currentTable, currentColumn, useLocalColumnInDisplayViews);

                    if (value.StartsWith("'", StringComparison.OrdinalIgnoreCase))
                    {
                        //If the value starts with a quote, find the value by the text.
                        ListItem item = dropDownList.Items.FindByText(value.Replace("'", ""));

                        if (item != null)
                        {
                            selectedItemValue = item.Value;
                        }
                    }
                    else
                    {
                        selectedItemValue = value;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(selectedItemValue))
            {
                dropDownList.SelectedValue = selectedItemValue;
            }
        }
    }
}