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

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("lock_out_id", autoIncrement=true)]
    [TableName("policy.lock_outs")]
    [ExplicitColumns]
    public sealed class LockOut : PetaPocoDB.Record<LockOut>, IPoco
    {
        [Column("lock_out_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.lock_outs_lock_out_id_seq'::regclass)")] 
        public long LockOutId { get; set; }
    
        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int UserId { get; set; }
    
        [Column("lock_out_time")]
        [ColumnDbType("timestamptz", 0, false, "")] 
        public DateTime LockOutTime { get; set; }
    
        [Column("lock_out_till")]
        [ColumnDbType("timestamptz", 0, false, "2015-09-15 17:23:09.1+00")] 
        public DateTime LockOutTill { get; set; }
    }
}