
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Config
{

    [TableName("config.attachment_factory_scrud_view")]
    [ExplicitColumns]
    public class AttachmentFactoryScrudView : PetaPocoDB.Record<AttachmentFactoryScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

    }

    [TableName("config.currency_layer_scrud_view")]
    [ExplicitColumns]
    public class CurrencyLayerScrudView : PetaPocoDB.Record<CurrencyLayerScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

    }

    [TableName("config.db_parameter_scrud_view")]
    [ExplicitColumns]
    public class DbParameterScrudView : PetaPocoDB.Record<DbParameterScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

    }

    [TableName("config.mixerp_scrud_view")]
    [ExplicitColumns]
    public class MixerpScrudView : PetaPocoDB.Record<MixerpScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

    }

    [TableName("config.open_exchange_rate_scrud_view")]
    [ExplicitColumns]
    public class OpenExchangeRateScrudView : PetaPocoDB.Record<OpenExchangeRateScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

    }

    [TableName("config.scrud_factory_scrud_view")]
    [ExplicitColumns]
    public class ScrudFactoryScrudView : PetaPocoDB.Record<ScrudFactoryScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

    }

    [TableName("config.switch_scrud_view")]
    [ExplicitColumns]
    public class SwitchScrudView : PetaPocoDB.Record<SwitchScrudView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? Value { get; set; }

    }

    [TableName("config.attachment_factory")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class AttachmentFactory : PetaPocoDB.Record<AttachmentFactory> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.currency_layer")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class CurrencyLayer : PetaPocoDB.Record<CurrencyLayer> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.db_parameters")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class DbParameter : PetaPocoDB.Record<DbParameter> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.mixerp")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class Mixerp : PetaPocoDB.Record<Mixerp> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.open_exchange_rates")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class OpenExchangeRate : PetaPocoDB.Record<OpenExchangeRate> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("description")] 
        [ColumnDbType("text", 0, "")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.scrud_factory")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class ScrudFactory : PetaPocoDB.Record<ScrudFactory> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, "")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.switches")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class Switch : PetaPocoDB.Record<Switch> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("bool", 0, "")] 
        public bool? Value { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.smtp")]
    [PrimaryKey("smtp_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Smtp : PetaPocoDB.Record<Smtp> , IPoco
    {
        [Column("smtp_id")] 
        [ColumnDbType("int4", 0, "nextval('config.smtp_smtp_id_seq'::regclass)")] 
        public int SmtpId { get; set; }

        [Column("configuration_name")] 
        [ColumnDbType("varchar", 256, "")] 
        public string ConfigurationName { get; set; }

        [Column("enabled")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool Enabled { get; set; }

        [Column("is_default")] 
        [ColumnDbType("bool", 0, "false")] 
        public bool IsDefault { get; set; }

        [Column("from_display_name")] 
        [ColumnDbType("varchar", 256, "")] 
        public string FromDisplayName { get; set; }

        [Column("from_email_address")] 
        [ColumnDbType("varchar", 256, "")] 
        public string FromEmailAddress { get; set; }

        [Column("smtp_host")] 
        [ColumnDbType("varchar", 256, "")] 
        public string SmtpHost { get; set; }

        [Column("smtp_port")] 
        [ColumnDbType("integer_strict", 0, "")] 
        public int SmtpPort { get; set; }

        [Column("smtp_enable_ssl")] 
        [ColumnDbType("bool", 0, "true")] 
        public bool SmtpEnableSsl { get; set; }

        [Column("smtp_username")] 
        [ColumnDbType("varchar", 256, "")] 
        public string SmtpUsername { get; set; }

        [Column("smtp_password")] 
        [ColumnDbType("varchar", 256, "")] 
        public string SmtpPassword { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime? AuditTs { get; set; }

    }
}

