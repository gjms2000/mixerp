
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.CRM
{

    [TableName("crm.lead_sources")]
    [PrimaryKey("lead_source_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LeadSource : PetaPocoDB.Record<LeadSource> , IPoco
    {
        [Column("lead_source_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int LeadSourceId { get; set; }

        [Column("lead_source_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string LeadSourceCode { get; set; }

        [Column("lead_source_name")] 
        [ColumnDbType("varchar", 128, "")] 
        public string LeadSourceName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("crm.lead_statuses")]
    [PrimaryKey("lead_status_id", autoIncrement=false)]
    [ExplicitColumns]
    public class LeadStatus : PetaPocoDB.Record<LeadStatus> , IPoco
    {
        [Column("lead_status_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int LeadStatusId { get; set; }

        [Column("lead_status_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string LeadStatusCode { get; set; }

        [Column("lead_status_name")] 
        [ColumnDbType("varchar", 128, "")] 
        public string LeadStatusName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }

    [TableName("crm.opportunity_stages")]
    [PrimaryKey("opportunity_stage_id", autoIncrement=false)]
    [ExplicitColumns]
    public class OpportunityStage : PetaPocoDB.Record<OpportunityStage> , IPoco
    {
        [Column("opportunity_stage_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int OpportunityStageId { get; set; }

        [Column("opportunity_stage_code")] 
        [ColumnDbType("varchar", 12, "")] 
        public string OpportunityStageCode { get; set; }

        [Column("opportunity_stage_name")] 
        [ColumnDbType("varchar", 50, "")] 
        public string OpportunityStageName { get; set; }

        [Column("audit_user_id")] 
        [ColumnDbType("int4", 0, "")] 
        public int? AuditUserId { get; set; }

        [Column("audit_ts")] 
        [ColumnDbType("timestamptz", 0, "now()")] 
        public DateTime? AuditTs { get; set; }

    }
}


