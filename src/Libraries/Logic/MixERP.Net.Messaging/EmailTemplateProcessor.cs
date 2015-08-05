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
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MixERP.Net.Messaging.Email
{
    public class EmailTemplateProcessor
    {
        public string Template { get; private set; }
        public List<object> Dictionary { get; private set; }

        public EmailTemplateProcessor(string template, List<object> dictionary)
        {
            this.Template = template;
            this.Dictionary = dictionary;
        }

        public string Process()
        {
            List<string> parameters = this.GetParameters();
            string template = this.Template;

            foreach (object item in this.Dictionary)
            {
                foreach (string parameter in parameters)
                {
                    string value = GetPropertyValue(item, parameter);

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        template = template.Replace("{" + parameter + "}", value);
                    }
                }
            }

            return template;
        }

        private List<string> GetParameters()
        {
            Regex regex = new Regex(@"(?<=\{)[^}]*(?=\})", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(this.Template);

            return matches.Cast<Match>().Select(m => m.Value.Replace("{", "}")).Distinct().ToList();
        }

        private static string GetPropertyValue(object obj, string propertyName)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            var prop = obj.GetType().GetProperty(propertyName);

            if (prop == null)
            {
                return string.Empty;
            }

            return prop.GetValue(obj, null).ToString();
        }
    }
}