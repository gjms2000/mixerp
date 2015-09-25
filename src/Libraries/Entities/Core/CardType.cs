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

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("card_type_id", autoIncrement = false)]
    [TableName("core.card_types")]
    [ExplicitColumns]
    public sealed class CardType : PetaPocoDB.Record<CardType>, IPoco
    {
        [Column("card_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CardTypeId { get; set; }

        [Column("card_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CardTypeCode { get; set; }

        [Column("card_type_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string CardTypeName { get; set; }
    }
}