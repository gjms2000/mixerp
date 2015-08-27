
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Audit
{

    [TableName("audit.failed_logins")]
    [PrimaryKey("failed_login_id", autoIncrement=false)]
    [ExplicitColumns]
    public class FailedLogin : PetaPocoDB.Record<FailedLogin> , IPoco
    {
        [Column("failed_login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long FailedLoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? UserId { get; set; }

        [Column("user_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string UserName { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? OfficeId { get; set; }

        [Column("browser")] 
        [ColumnDbType("varchar", 500, "")] 
        public string Browser { get; set; }

        [Column("ip_address")] 
        [ColumnDbType("varchar", 50, "")] 
        public string IpAddress { get; set; }

        [Column("failed_date_time")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime FailedDateTime { get; set; }

        [Column("remote_user")] 
        [ColumnDbType("varchar", 50, "")] 
        public string RemoteUser { get; set; }

        [Column("details")] 
        [ColumnDbType("varchar", 250, "")] 
        public string Details { get; set; }

    }

    [TableName("audit.logged_actions")]
    [PrimaryKey("event_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LoggedAction : PetaPocoDB.Record<LoggedAction> , IPoco
    {
        [Column("event_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long EventId { get; set; }

        [Column("schema_name")] 
        [ColumnDbType("text", 0, "")] 
        public string SchemaName { get; set; }

        [Column("table_name")] 
        [ColumnDbType("text", 0, "")] 
        public string TableName { get; set; }

        [Column("relid")] 
        [ColumnDbType("oid", 0, "")] 
        public string Relid { get; set; }

        [Column("session_user_name")] 
        [ColumnDbType("text", 0, "")] 
        public string SessionUserName { get; set; }

        [Column("application_user_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ApplicationUserName { get; set; }

        [Column("action_tstamp_tx")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime ActionTstampTx { get; set; }

        [Column("action_tstamp_stm")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime ActionTstampStm { get; set; }

        [Column("action_tstamp_clk")] 
        [ColumnDbType("timestamptz", 0, "")] 
        public DateTime ActionTstampClk { get; set; }

        [Column("transaction_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long? TransactionId { get; set; }

        [Column("application_name")] 
        [ColumnDbType("text", 0, "")] 
        public string ApplicationName { get; set; }

        [Column("client_addr")] 
        [ColumnDbType("inet", 0, "")] 
        public string ClientAddr { get; set; }

        [Column("client_port")] 
        [ColumnDbType("int4", 0, "")] 
        public int? ClientPort { get; set; }

        [Column("client_query")] 
        [ColumnDbType("text", 0, "")] 
        public string ClientQuery { get; set; }

        [Column("action")] 
        [ColumnDbType("text", 0, "")] 
        public string Action { get; set; }

        [Column("row_data")] 
        [ColumnDbType("hstore", 0, "")] 
        public string RowData { get; set; }

        [Column("changed_fields")] 
        [ColumnDbType("hstore", 0, "")] 
        public string ChangedFields { get; set; }

        [Column("statement_only")] 
        [ColumnDbType("bool", 0, "")] 
        public bool StatementOnly { get; set; }

    }

    [TableName("audit.logins")]
    [PrimaryKey("login_id", autoIncrement=false)]
    [ExplicitColumns]
    public class Login : PetaPocoDB.Record<Login> , IPoco
    {
        [Column("login_id")] 
        [ColumnDbType("int8", 0, "")] 
        public long LoginId { get; set; }

        [Column("user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int UserId { get; set; }

        [Column("office_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OfficeId { get; set; }

        [Column("browser")] 
        [ColumnDbType("varchar", 500, "")] 
        public string Browser { get; set; }

        [Column("ip_address")] 
        [ColumnDbType("varchar", 50, "")] 
        public string IpAddress { get; set; }

        [Column("login_date_time")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime LoginDateTime { get; set; }

        [Column("remote_user")] 
        [ColumnDbType("varchar", 50, "")] 
        public string RemoteUser { get; set; }

        [Column("culture")] 
        [ColumnDbType("varchar", 12, "")] 
        public string Culture { get; set; }

    }

    [FunctionName("get_office_information_model")]
    [ExplicitColumns]
    public class DbGetOfficeInformationModelResult : PetaPocoDB.Record<DbGetOfficeInformationModelResult> , IPoco
    {
        [Column("office")] 
        [ColumnDbType("text", 0, "")] 
        public string Office { get; set; }

        [Column("logged_in_to")] 
        [ColumnDbType("text", 0, "")] 
        public string LoggedInTo { get; set; }

        [Column("last_login_ip")] 
        [ColumnDbType("text", 0, "")] 
        public string LastLoginIp { get; set; }

        [Column("last_login_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime LastLoginOn { get; set; }

        [Column("current_ip")] 
        [ColumnDbType("text", 0, "")] 
        public string CurrentIp { get; set; }

        [Column("current_login_on")] 
        [ColumnDbType("timestamp with time zone", 0, "")] 
        public DateTime CurrentLoginOn { get; set; }

        [Column("role")] 
        [ColumnDbType("text", 0, "")] 
        public string Role { get; set; }

        [Column("department")] 
        [ColumnDbType("text", 0, "")] 
        public string Department { get; set; }

    }
}

