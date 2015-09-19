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
    [PrimaryKey("education_level_id", autoIncrement = true)]
    [TableName("hrm.education_levels")]
    [ExplicitColumns]
    public sealed class EducationLevel : PetaPocoDB.Record<EducationLevel>, IPoco
    {
        [Column("education_level_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.education_levels_education_level_id_seq'::regclass)")]
        public int EducationLevelId { get; set; }

        [Column("education_level_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string EducationLevelName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}