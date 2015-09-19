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

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.contract_scrud_view")]
    [ExplicitColumns]
    public sealed class ContractScrudView : PetaPocoDB.Record<ContractScrudView>, IPoco
    {
        [Column("contract_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ContractId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("department")]
        [ColumnDbType("text", 0, true, "")]
        public string Department { get; set; }

        [Column("role")]
        [ColumnDbType("text", 0, true, "")]
        public string Role { get; set; }

        [Column("leave_benefit")]
        [ColumnDbType("text", 0, true, "")]
        public string LeaveBenefit { get; set; }

        [Column("employment_status_code")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatusCode { get; set; }

        [Column("began_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? BeganOn { get; set; }

        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndedOn { get; set; }
    }
}