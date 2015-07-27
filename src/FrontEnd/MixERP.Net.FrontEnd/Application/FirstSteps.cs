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
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;

namespace MixERP.Net.FrontEnd.Application
{
    public static class FirstSteps
    {
        public static bool CheckIfPending()
        {
            if (!AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return false;
            }

            IEnumerable<FirstStep> list = FirstStep.GetAll().Where(x => !x.Status);

            if (list.Any())
            {
                return true;
            }

            return false;
        }
    }
}