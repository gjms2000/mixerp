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
using MixERP.Net.FrontEnd.Application;

namespace MixERP.Net.FrontEnd
{
    public partial class PostSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Context.Session["FirstStepsPending"] = FirstSteps.CheckIfPending();

            this.Context.Response.Redirect(this.GetReturnUrl());
        }

        private string GetReturnUrl()
        {
            string returnUrl = this.Context.Request.QueryString["ReturnUrl"];

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return "~";
            }

            return returnUrl;
        }
    }
}