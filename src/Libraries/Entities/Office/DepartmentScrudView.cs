// ReSharper disable All
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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.department_scrud_view")]
    [ExplicitColumns]
    public sealed class DepartmentScrudView : PetaPocoDB.Record<DepartmentScrudView>, IPoco
    {
        [Column("department_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DepartmentId { get; set; }

        [Column("department_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string DepartmentCode { get; set; }

        [Column("department_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string DepartmentName { get; set; }
    }
}