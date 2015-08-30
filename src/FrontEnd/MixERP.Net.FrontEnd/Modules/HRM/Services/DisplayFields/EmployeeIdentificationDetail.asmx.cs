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
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.Core.Modules.HRM.Data;

namespace MixERP.Net.Core.Modules.HRM.Services.DisplayFields
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public sealed class EmployeeIdentificationDetail : MixERPWebService
    {
	    [WebMethod]
		public List<DisplayField> GetDisplayField()
		{			
			return MixERP.Net.Core.Modules.HRM.Data.EmployeeIdentificationDetail.GetDisplayFields(this.Catalog).ToList();
		}
	}
}