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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("party_type_id", autoIncrement = true)]
    [TableName("core.party_types")]
    [ExplicitColumns]
    public sealed class PartyType : PetaPocoDB.Record<PartyType>, IPoco
    {
        [Column("party_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.party_types_party_type_id_seq'::regclass)")]
        public int PartyTypeId { get; set; }

        [Column("party_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string PartyTypeName { get; set; }

        [Column("is_supplier")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsSupplier { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}