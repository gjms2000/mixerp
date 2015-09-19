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

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("routine_id", autoIncrement = true)]
    [TableName("transactions.routines")]
    [ExplicitColumns]
    public sealed class Routine : PetaPocoDB.Record<Routine>, IPoco
    {
        [Column("routine_id")]
        [ColumnDbType("int4", 0, false, "nextval('transactions.routines_routine_id_seq'::regclass)")]
        public int RoutineId { get; set; }

        [Column("order")]
        [ColumnDbType("int4", 0, false, "")]
        public int Order { get; set; }

        [Column("routine_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string RoutineCode { get; set; }

        [Column("routine_name")]
        [ColumnDbType("regproc", 0, false, "")]
        public string RoutineName { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool Status { get; set; }
    }
}