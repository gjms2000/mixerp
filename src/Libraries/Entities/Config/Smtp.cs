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

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("smtp_id", autoIncrement = true)]
    [TableName("config.smtp")]
    [ExplicitColumns]
    public sealed class Smtp : PetaPocoDB.Record<Smtp>, IPoco
    {
        [Column("smtp_id")]
        [ColumnDbType("int4", 0, false, "nextval('config.smtp_smtp_id_seq'::regclass)")]
        public int SmtpId { get; set; }

        [Column("configuration_name")]
        [ColumnDbType("varchar", 256, false, "")]
        public string ConfigurationName { get; set; }

        [Column("enabled")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Enabled { get; set; }

        [Column("is_default")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsDefault { get; set; }

        [Column("from_display_name")]
        [ColumnDbType("varchar", 256, false, "")]
        public string FromDisplayName { get; set; }

        [Column("from_email_address")]
        [ColumnDbType("varchar", 256, false, "")]
        public string FromEmailAddress { get; set; }

        [Column("smtp_host")]
        [ColumnDbType("varchar", 256, false, "")]
        public string SmtpHost { get; set; }

        [Column("smtp_port")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int SmtpPort { get; set; }

        [Column("smtp_enable_ssl")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool SmtpEnableSsl { get; set; }

        [Column("smtp_username")]
        [ColumnDbType("varchar", 256, false, "")]
        public string SmtpUsername { get; set; }

        [Column("smtp_password")]
        [ColumnDbType("varchar", 256, false, "")]
        public string SmtpPassword { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}