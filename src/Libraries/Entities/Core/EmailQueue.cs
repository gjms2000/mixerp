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
    [PrimaryKey("queue_id", autoIncrement = true)]
    [TableName("core.email_queue")]
    [ExplicitColumns]
    public sealed class EmailQueue : PetaPocoDB.Record<EmailQueue>, IPoco
    {
        [Column("queue_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.email_queue_queue_id_seq'::regclass)")]
        public long QueueId { get; set; }

        [Column("subject")]
        [ColumnDbType("varchar", 256, false, "")]
        public string Subject { get; set; }

        [Column("send_to")]
        [ColumnDbType("varchar", 256, false, "")]
        public string SendTo { get; set; }

        [Column("attachments")]
        [ColumnDbType("text", 0, true, "")]
        public string Attachments { get; set; }

        [Column("message")]
        [ColumnDbType("text", 0, false, "")]
        public string Message { get; set; }

        [Column("added_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime AddedOn { get; set; }

        [Column("delivered")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Delivered { get; set; }

        [Column("delivered_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? DeliveredOn { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionMasterId { get; set; }

        [Column("canceled")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Canceled { get; set; }
    }
}