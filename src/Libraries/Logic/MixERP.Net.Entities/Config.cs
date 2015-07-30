
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

    [TableName("config.messaging")]
    [PrimaryKey("key", autoIncrement=false)]
    [ExplicitColumns]
    public class Messaging : PetaPocoDB.Record<Messaging> , IPoco
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

    [TableName("config.messaging_scrud_view")]
    [ExplicitColumns]
    public class MessagingScrudView : PetaPocoDB.Record<MessagingScrudView> , IPoco
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

