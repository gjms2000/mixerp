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

using System.Linq;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Core
{
    public static class Workflow
    {
        public static DbGetWorkflowModelResult GetWorkflowModel(string catalog)
        {
            const string sql = "SELECT * FROM core.get_workflow_model();";
            return Factory.Get<DbGetWorkflowModelResult>(catalog, sql).FirstOrDefault();
        }
    }
}