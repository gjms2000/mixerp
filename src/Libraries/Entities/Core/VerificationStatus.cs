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
    [PrimaryKey("verification_status_id", autoIncrement = false)]
    [TableName("core.verification_statuses")]
    [ExplicitColumns]
    public sealed class VerificationStatus : PetaPocoDB.Record<VerificationStatus>, IPoco
    {
        [Column("verification_status_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short VerificationStatusId { get; set; }

        [Column("verification_status_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string VerificationStatusName { get; set; }
    }
}