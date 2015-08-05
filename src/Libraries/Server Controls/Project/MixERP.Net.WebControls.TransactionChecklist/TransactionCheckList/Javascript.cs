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

using System.IO;
using MixERP.Net.Common.Helpers;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using MixERP.Net.Common;

[assembly: WebResource("MixERP.Net.WebControls.TransactionChecklist.Scripts.TransactionChecklist.js", "application/x-javascript")]
namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
        private void AddScript()
        {
            string fileName = Path.GetFileName(this.AttachmentFileName);
            var script = JSUtility.GetVar("fileName", fileName);

            PageUtility.RegisterJavascript("Checklist", script, this.Page, true);
            JSUtility.AddJSReference(this.Page, "MixERP.Net.WebControls.TransactionChecklist.Scripts.TransactionChecklist.js", "TransactionChecklistForm", typeof(TransactionChecklistForm));
        }
    }
}