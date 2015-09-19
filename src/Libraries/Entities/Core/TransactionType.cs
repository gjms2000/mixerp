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
    [PrimaryKey("transaction_type_id", autoIncrement = false)]
    [TableName("core.transaction_types")]
    [ExplicitColumns]
    public sealed class TransactionType : PetaPocoDB.Record<TransactionType>, IPoco
    {
        [Column("transaction_type_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short TransactionTypeId { get; set; }

        [Column("transaction_type_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string TransactionTypeCode { get; set; }

        [Column("transaction_type_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string TransactionTypeName { get; set; }
    }
}