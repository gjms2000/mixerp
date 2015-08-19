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

using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.ScrudFactory.Helpers;

namespace MixERP.Net.WebControls.ScrudFactory.Controls.TextBoxes
{
    internal static class ScrudTextBox
    {
        internal static void AddTextBox(HtmlTable htmlTable, string resourceClassName, string columnName, string label, string description,
            string dataType, string defaultValue, bool isNullable, int maxLength, string errorCssClass, bool disabled)
        {
            if (htmlTable == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(columnName))
            {
                return;
            }

            bool isPasswordField = columnName.ToUpperInvariant().Contains("PASSWORD");

            if (isPasswordField && disabled)
            {
                defaultValue = "fake-password";
            }

            using (TextBox textBox = GetTextBox(columnName + "_textbox", maxLength))
            {
                if (string.IsNullOrWhiteSpace(label))
                {
                    label = ScrudLocalizationHelper.GetResourceString(resourceClassName, columnName);
                }


                if (dataType.ToUpperInvariant().Equals("COLOR"))
                {
                    textBox.CssClass = "color";
                }

                if (dataType.ToUpperInvariant().Equals("IMAGE"))
                {
                    textBox.CssClass = "image";
                }

                if (isPasswordField)
                {
                    textBox.Attributes.Add("type", "password");
                }

                if (disabled && !isPasswordField)
                {
                    textBox.ReadOnly = true;
                }

                if (!string.IsNullOrWhiteSpace(description))
                {
                    textBox.CssClass += " activating element";
                    textBox.Attributes.Add("data-content", description);
                }

                textBox.Text = defaultValue;


                if (!isNullable)
                {
                    using (
                        RequiredFieldValidator required = ScrudFactoryHelper.GetRequiredFieldValidator(textBox,
                            errorCssClass))
                    {
                        ScrudFactoryHelper.AddRow(htmlTable, label + Labels.RequiredFieldIndicator, textBox, required);
                        return;
                    }
                }

                ScrudFactoryHelper.AddRow(htmlTable, label, textBox);
            }
        }

        internal static TextBox GetTextBox(string id, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            using (TextBox textBox = new TextBox())
            {
                textBox.ID = id;
                textBox.ClientIDMode = ClientIDMode.Static;

                if (maxLength > 0)
                {
                    textBox.MaxLength = maxLength;
                }


                return textBox;
            }
        }
    }
}