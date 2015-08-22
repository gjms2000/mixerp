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
using System.Globalization;
using System.Threading;
using System.Web.UI;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Common.jQueryHelper;
using MixERP.Net.i18n;

namespace MixERP.Net.FrontEnd.Base
{
    public class MixERPMasterPage : MasterPage
    {
        protected override void OnLoad(EventArgs e)
        {
            this.RegisterJavascript();
            base.OnLoad(e);
        }

        private void RegisterJavascript()
        {
            string script = JSUtility.GetVar("culture", CultureManager.GetCurrent().Name);
            script += JSUtility.GetVar("language", CultureManager.GetCurrent().TwoLetterISOLanguageName);
            script += JSUtility.GetVar("jqueryUIi18nPath", this.Page.ResolveUrl("~/Scripts/jquery-ui/i18n/"));

            script += JSUtility.GetVar("today", string.Format(CultureManager.GetCurrent(), CultureManager.GetCurrent().DateTimeFormat.ShortDatePattern, DateTime.Now));
            script += JSUtility.GetVar("now", DateTime.Now.ToString(CultureManager.GetCurrent()));

            script += JSUtility.GetVar("user", AppUsers.GetCurrent().View.UserName);
            script += JSUtility.GetVar("office", AppUsers.GetCurrent().View.OfficeName);

            script += JSUtility.GetVar("shortDateFormat", CultureManager.GetShortDateFormat());
            script += JSUtility.GetVar("longDateFormat", CultureManager.GetLongDateFormat());

            script += JSUtility.GetVar("thousandSeparator", CultureManager.GetThousandSeparator());
            script += JSUtility.GetVar("decimalSeparator", CultureManager.GetDecimalSeparator());
            script += JSUtility.GetVar("currencyDecimalPlaces", CultureManager.GetCurrencyDecimalPlaces());
            script += JSUtility.GetVar("currencySymbol", CultureManager.GetCurrencySymbol());


            script += JSUtility.GetVar("today", DateTime.Now.ToShortDateString());
            script += JSUtility.GetVar("shortDateFormat", CultureManager.GetShortDateFormat());
            script += JSUtility.GetVar("thousandSeparator", CultureManager.GetThousandSeparator());
            script += JSUtility.GetVar("decimalSeparator", CultureManager.GetDecimalSeparator());
            script += JSUtility.GetVar("currencyDecimalPlaces", CultureManager.GetCurrencyDecimalPlaces());
            script += JSUtility.GetVar("baseCurrencyCode", AppUsers.GetCurrent().View.CurrencyCode);


            script += JSUtility.GetVar("catalog", AppUsers.GetCurrentUserDB());

            script += JSUtility.GetVar("update", this.Update());

            script += JSUtility.GetVar("firstStepsPending", this.Context.Session["FirstStepsPending"]);

            script += JSUtility.GetVar("datepickerFormat", jQueryUI.GetDatePickerFormat());
            script += JSUtility.GetVar("datepickerShowWeekNumber", jQueryUI.ShowWeekNumber());
            script += JSUtility.GetVar("datepickerWeekStartDay", jQueryUI.GetWeekStartDay());
            script += JSUtility.GetVar("datepickerNumberOfMonths", jQueryUI.GetNumberOfMonths());


            PageUtility.RegisterJavascript("MixERPMasterPage", script, this.Page, true);
        }

        private int Update()
        {
            if (Conversion.TryCastBoolean(this.Application["UpdateAvailable"]) &&
                AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return 1;
            }

            return 0;
        }
    }
}