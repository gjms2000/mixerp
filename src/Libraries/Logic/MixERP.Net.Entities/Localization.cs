
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Localization
{

    [TableName("localization.resources")]
    [PrimaryKey("resource_id", autoIncrement=true)]
    [ExplicitColumns]
    public class Resource : PetaPocoDB.Record<Resource> , IPoco
    {
        [Column("resource_id")] 
        [ColumnDbType("int4", 0, false, "nextval('localization.resources_resource_id_seq'::regclass)")] 
        public int ResourceId { get; set; }

        [Column("resource_class")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ResourceClass { get; set; }

        [Column("key")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Value { get; set; }

    }

    [TableName("localization.cultures")]
    [PrimaryKey("culture_code", autoIncrement=false)]
    [ExplicitColumns]
    public class Culture : PetaPocoDB.Record<Culture> , IPoco
    {
        [Column("culture_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string CultureCode { get; set; }

        [Column("culture_name")] 
        [ColumnDbType("text", 0, true, "")] 
        public string CultureName { get; set; }

    }

    [TableName("localization.localized_resources")]
    [ExplicitColumns]
    public class LocalizedResource : PetaPocoDB.Record<LocalizedResource> , IPoco
    {
        [Column("resource_id")] 
        [ColumnDbType("int4", 0, false, "")] 
        public int ResourceId { get; set; }

        [Column("culture_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string CultureCode { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Value { get; set; }

    }

    [TableName("localization.resource_view")]
    [ExplicitColumns]
    public class ResourceView : PetaPocoDB.Record<ResourceView> , IPoco
    {
        [Column("resource_class")] 
        [ColumnDbType("text", 0, true, "")] 
        public string ResourceClass { get; set; }

        [Column("culture")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Culture { get; set; }

        [Column("key")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Value { get; set; }

    }

    [TableName("localization.localized_resource_view")]
    [ExplicitColumns]
    public class LocalizedResourceView : PetaPocoDB.Record<LocalizedResourceView> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, true, "")] 
        public string Value { get; set; }

    }

    [FunctionName("get_menu_table")]
    [ExplicitColumns]
    public class DbGetMenuTableResult : PetaPocoDB.Record<DbGetMenuTableResult> , IPoco
    {
        [Column("menu_code")] 
        [ColumnDbType("text", 0, false, "")] 
        public string MenuCode { get; set; }

        [Column("invariant")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Invariant { get; set; }

        [Column("localized")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Localized { get; set; }

    }

    [FunctionName("get_localization_table")]
    [ExplicitColumns]
    public class DbGetLocalizationTableResult : PetaPocoDB.Record<DbGetLocalizationTableResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("resource_class")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ResourceClass { get; set; }

        [Column("key")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Key { get; set; }

        [Column("original")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Original { get; set; }

        [Column("translated")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Translated { get; set; }

    }
}


