
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Config
{

    [TableName("config.attachment_factory")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class AttachmentFactory : PetaPocoDB.Record<AttachmentFactory> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.currency_layer")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class CurrencyLayer : PetaPocoDB.Record<CurrencyLayer> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.mixerp")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class Mixerp : PetaPocoDB.Record<Mixerp> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.db_parameters")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class DbParameter : PetaPocoDB.Record<DbParameter> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.scrud_factory")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class ScrudFactory : PetaPocoDB.Record<ScrudFactory> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.switches")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class Switch : PetaPocoDB.Record<Switch> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public bool? Value { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.smtp")]
    [PrimaryKey("smtp_id")]
    [ExplicitColumns]
    public class Smtp : PetaPocoDB.Record<Smtp> , IPoco
    {
        [Column("smtp_id")] 
        public int SmtpId { get; set; }

        [Column("configuration_name")] 
        public string ConfigurationName { get; set; }

        [Column("enabled")] 
        public bool Enabled { get; set; }

        [Column("is_default")] 
        public bool IsDefault { get; set; }

        [Column("from_display_name")] 
        public string FromDisplayName { get; set; }

        [Column("from_email_address")] 
        public string FromEmailAddress { get; set; }

        [Column("smtp_host")] 
        public string SmtpHost { get; set; }

        [Column("smtp_enable_ssl")] 
        public bool SmtpEnableSsl { get; set; }

        [Column("smtp_username")] 
        public string SmtpUsername { get; set; }

        [Column("smtp_password")] 
        public string SmtpPassword { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.open_exchange_rates")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class OpenExchangeRate : PetaPocoDB.Record<OpenExchangeRate> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

        [Column("audit_user_id")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("config.attachment_factory_scrud_view")]
    [ExplicitColumns]
    public class AttachmentFactoryScrudView : PetaPocoDB.Record<AttachmentFactoryScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

    }

    [TableName("config.currency_layer_scrud_view")]
    [ExplicitColumns]
    public class CurrencyLayerScrudView : PetaPocoDB.Record<CurrencyLayerScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

    }

    [TableName("config.db_parameter_scrud_view")]
    [ExplicitColumns]
    public class DbParameterScrudView : PetaPocoDB.Record<DbParameterScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

    }

    [TableName("config.mixerp_scrud_view")]
    [ExplicitColumns]
    public class MixerpScrudView : PetaPocoDB.Record<MixerpScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

    }

    [TableName("config.open_exchange_rate_scrud_view")]
    [ExplicitColumns]
    public class OpenExchangeRateScrudView : PetaPocoDB.Record<OpenExchangeRateScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

        [Column("description")] 
        public string Description { get; set; }

    }

    [TableName("config.scrud_factory_scrud_view")]
    [ExplicitColumns]
    public class ScrudFactoryScrudView : PetaPocoDB.Record<ScrudFactoryScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public string Value { get; set; }

    }

    [TableName("config.switch_scrud_view")]
    [ExplicitColumns]
    public class SwitchScrudView : PetaPocoDB.Record<SwitchScrudView> , IPoco
    {
        [Column("key")] 
        public string Key { get; set; }

        [Column("value")] 
        public bool? Value { get; set; }

    }
}

