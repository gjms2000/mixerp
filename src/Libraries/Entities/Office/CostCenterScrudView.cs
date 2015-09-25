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
    [TableName("office.cost_center_scrud_view")]
    [ExplicitColumns]
    public sealed class CostCenterScrudView : PetaPocoDB.Record<CostCenterScrudView>, IPoco
    {
        [Column("cost_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CostCenterId { get; set; }

        [Column("cost_center_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string CostCenterCode { get; set; }

        [Column("cost_center_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CostCenterName { get; set; }
    }
}