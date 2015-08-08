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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.Common;
using MixERP.Net.Entities.Core;
using MixERP.Net.WebControls.ScrudFactory.Controls;
using MixERP.Net.WebControls.ScrudFactory.Data;
using MixERP.Net.WebControls.ScrudFactory.Helpers;

namespace MixERP.Net.WebControls.ScrudFactory
{
    public partial class ScrudForm
    {
        /// <summary>
        ///     This function iterates through all the dynamically added controls,
        ///     checks their values, and returns a list of column and values
        ///     mapped as KeyValuePair of column_name (key) and value.
        /// </summary>
        /// <param name="skipSerial">
        ///     Skip the PostgreSQL serial column.
        ///     There is no need to explicitly set the value for the serial column.
        ///     This value should be <strong>true</strong> if you are obtaining the form to insert the record.
        ///     Set this parameter to <b>false</b> if you want to update the form, based on the serial's columns value.
        /// </param>
        /// <returns>
        ///     Returns a list of column and values mapped as
        ///     KeyValuePair of column_name (key) and value.
        /// </returns>
        private Collection<KeyValuePair<string, object>> GetFormCollection(bool skipSerial)
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();

            using (DataTable table = TableHelper.GetTable(this.Catalog, this.TableSchema, this.Table, this.Exclude))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string columnName = Conversion.TryCastString(row["column_name"]);
                        string defaultValue = Conversion.TryCastString(row["column_default"]);
                        bool isSerial = defaultValue.StartsWith("nextval", StringComparison.OrdinalIgnoreCase);
                        string parentTableColumn = Conversion.TryCastString(row["references_field"]);
                        string dataType = Conversion.TryCastString(row["data_type"]);

                        if (skipSerial)
                        {
                            if (isSerial)
                            {
                                continue;
                            }
                        }

                        this.AddToList(ref list, columnName, parentTableColumn, dataType);
                    }
                }
            }

            return list;
        }
        /// <summary>
        ///     This function iterates through all the dynamically added controls,
        ///     checks their values, and returns a list of column and values
        ///     mapped as KeyValuePair of column_name (key) and value.
        /// </summary>
        /// <returns>
        ///     Returns a list of column and values mapped as
        ///     KeyValuePair of column_name (key) and value.
        /// </returns>
        private Collection<KeyValuePair<string, object>> GetCustomFieldCollection()
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            var customFields = FormHelper.GetCustomFieldSetups(this.Catalog, this.TableSchema, this.Table).ToList();

            if (customFields.Any())
            {
                foreach (var customField in customFields)
                {
                    string columnName = customField.FieldName;
                    string dataType = customField.DataType;
                    this.AddToList(ref list, columnName, string.Empty, dataType);

                }
            }

            return list;
        }

        private void AddToList(ref Collection<KeyValuePair<string, object>> list, string columnName,
            string parentTableColumn, string dataType)
        {
            if (string.IsNullOrWhiteSpace(parentTableColumn))
            {
                if (ScrudTypes.TextBoxTypes.Contains(dataType))
                {
                    using (
                        TextBox textBox = this.formContainer.FindControl(columnName + "_textbox") as TextBox
                        )
                    {
                        if (textBox != null)
                        {
                            list.Add(new KeyValuePair<string, object>(columnName,
                                ScrudParser.ParseValue(textBox.Text, dataType)));
                        }
                    }
                }

                if (ScrudTypes.Bools.Contains(dataType))
                {
                    using (
                        RadioButtonList radioButtonList =
                            this.formContainer.FindControl(columnName + "_radiobuttonlist") as
                                RadioButtonList)
                    {
                        if (radioButtonList != null)
                        {
                            list.Add(new KeyValuePair<string, object>(columnName,
                                ScrudParser.ParseValue(radioButtonList.Text, dataType)));
                        }
                    }
                }
            }
            else
            {
                //DropDownList
                using (
                    DropDownList dropDownList =
                        this.formContainer.FindControl(columnName + "_dropdownlist") as DropDownList)
                {
                    object value = null;

                    if (dropDownList != null && !string.IsNullOrWhiteSpace(dropDownList.Text))
                    {
                        value = dropDownList.SelectedValue;
                    }

                    list.Add(new KeyValuePair<string, object>(columnName, value));
                }
            }
        }

        private void LoadForm(Panel container, DataTable values, string id = "", bool editing = false)
        {
            using (HtmlTable htmlTable = new HtmlTable())
            {
                htmlTable.Attributes.Add("role", "scrud");

                using (DataTable table = TableHelper.GetTable(this.Catalog, this.TableSchema, this.Table, this.Exclude))
                {
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            string columnName = Conversion.TryCastString(row["column_name"]);
                            string defaultValue = Conversion.TryCastString(row["column_default"]);
                            bool isSerial = defaultValue.StartsWith("nextval", StringComparison.OrdinalIgnoreCase);
                            bool isNullable = Conversion.TryCastBoolean(row["is_nullable"]);
                            string dataType = Conversion.TryCastString(row["data_type"]);
                            string domain = Conversion.TryCastString(row["domain_name"]);
                            int maxLength = Conversion.TryCastInteger(row["character_maximum_length"]);

                            string parentTableSchema = Conversion.TryCastString(row["references_schema"]);
                            string parentTable = Conversion.TryCastString(row["references_table"]);
                            string parentTableColumn = Conversion.TryCastString(row["references_field"]);

                            if (values.Rows.Count.Equals(1))
                            {
                                defaultValue = Conversion.TryCastString(values.Rows[0][columnName]);
                            }

                            bool disabled = false;

                            if (editing)
                            {
                                if (!string.IsNullOrWhiteSpace(this.ExcludeEdit))
                                {
                                    if (
                                        this.ExcludeEdit.Split(',')
                                            .Any(
                                                column =>
                                                    column.Trim()
                                                        .ToUpperInvariant()
                                                        .Equals(columnName.ToUpperInvariant())))
                                    {
                                        disabled = true;
                                    }
                                }
                            }


                            ScrudFactoryHelper.AddField(this.Catalog, htmlTable, this.GetResourceClassName(),
                                this.GetItemSelectorPath(), this.TableSchema, this.Table, columnName, string.Empty, string.Empty,
                                defaultValue,
                                isSerial, isNullable, dataType,
                                domain, maxLength, parentTableSchema, parentTable, parentTableColumn, this.DisplayFields,
                                this.DisplayViews, this.UseDisplayViewsAsParents, this.SelectedValues,
                                this.GetErrorCssClass(), disabled, this.UseLocalColumnInDisplayViews);
                        }
                    }
                }

                var customFields = FormHelper.GetCustomFieldSetups(this.Catalog, this.TableSchema, this.Table).ToList();

                if (customFields.Any())
                {
                    foreach (CustomFieldSetup field in customFields)
                    {
                        string defaultValue = string.Empty;

                        if (editing)
                        {
                            defaultValue = this.GetCustomFieldValue(this.TableSchema, this.Table, field.FieldName, id);
                        }

                        ScrudFactoryHelper.AddField(this.Catalog, htmlTable, "",
                            this.GetItemSelectorPath(), this.TableSchema, this.Table, field.FieldName, field.FieldLabel, field.Description,
                            defaultValue,
                            false, true, field.DataType,
                            "", 100, "", "", "", this.DisplayFields,
                            this.DisplayViews, this.UseDisplayViewsAsParents, this.SelectedValues,
                            this.GetErrorCssClass(), false, this.UseLocalColumnInDisplayViews);
                    }
                }

                container.Controls.Add(htmlTable);
            }
        }

        private string GetCustomFieldValue(string schema, string table, string fieldName, string id)
        {
            return FormHelper.GetCustomFieldValue(this.Catalog, schema, table, fieldName, id);
        }
    }
}