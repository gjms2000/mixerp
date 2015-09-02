
using MixERP.Net.Entities.Contracts;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixERP.Net.Entities.Public
{

    [TableName("public.db_stat")]
    [ExplicitColumns]
    public class DbStat : PetaPocoDB.Record<DbStat> , IPoco
    {
        [Column("relname")] 
        [ColumnDbType("name", 0, true, "")] 
        public string Relname { get; set; }

        [Column("last_vacuum")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastVacuum { get; set; }

        [Column("last_autovacuum")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAutovacuum { get; set; }

        [Column("last_analyze")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAnalyze { get; set; }

        [Column("last_autoanalyze")] 
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? LastAutoanalyze { get; set; }

        [Column("vacuum_count")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? VacuumCount { get; set; }

        [Column("autovacuum_count")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AutovacuumCount { get; set; }

        [Column("analyze_count")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AnalyzeCount { get; set; }

        [Column("autoanalyze_count")] 
        [ColumnDbType("int8", 0, true, "")] 
        public long? AutoanalyzeCount { get; set; }

    }

    [FunctionName("crosstab4")]
    [ExplicitColumns]
    public class DbCrosstab4Result : PetaPocoDB.Record<DbCrosstab4Result> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

        [Column("category_3")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category3 { get; set; }

        [Column("category_4")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category4 { get; set; }

    }

    [FunctionName("crosstab3")]
    [ExplicitColumns]
    public class DbCrosstab3Result : PetaPocoDB.Record<DbCrosstab3Result> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

        [Column("category_3")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category3 { get; set; }

    }

    [FunctionName("each")]
    [ExplicitColumns]
    public class DbEachResult : PetaPocoDB.Record<DbEachResult> , IPoco
    {
        [Column("key")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Key { get; set; }

        [Column("value")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Value { get; set; }

    }

    [FunctionName("crosstab2")]
    [ExplicitColumns]
    public class DbCrosstab2Result : PetaPocoDB.Record<DbCrosstab2Result> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

    }

    [FunctionName("poco_get_table_function_definition")]
    [ExplicitColumns]
    public class DbPocoGetTableFunctionDefinitionResult : PetaPocoDB.Record<DbPocoGetTableFunctionDefinitionResult> , IPoco
    {
        [Column("id")] 
        [ColumnDbType("bigint", 0, false, "")] 
        public long Id { get; set; }

        [Column("column_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ColumnName { get; set; }

        [Column("is_nullable")] 
        [ColumnDbType("text", 0, false, "")] 
        public string IsNullable { get; set; }

        [Column("udt_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string UdtName { get; set; }

        [Column("column_default")] 
        [ColumnDbType("text", 0, false, "")] 
        public string ColumnDefault { get; set; }

        [Column("max_length")] 
        [ColumnDbType("integer", 0, false, "")] 
        public int MaxLength { get; set; }

        [Column("is_primary_key")] 
        [ColumnDbType("text", 0, false, "")] 
        public string IsPrimaryKey { get; set; }

    }

    [TableName("public.tablefunc_crosstab_2")]
    [ExplicitColumns]
    public class TablefuncCrosstab2 : PetaPocoDB.Record<TablefuncCrosstab2> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

    }

    [TableName("public.tablefunc_crosstab_3")]
    [ExplicitColumns]
    public class TablefuncCrosstab3 : PetaPocoDB.Record<TablefuncCrosstab3> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

        [Column("category_3")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category3 { get; set; }

    }

    [TableName("public.tablefunc_crosstab_4")]
    [ExplicitColumns]
    public class TablefuncCrosstab4 : PetaPocoDB.Record<TablefuncCrosstab4> , IPoco
    {
        [Column("row_name")] 
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }

        [Column("category_1")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }

        [Column("category_2")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }

        [Column("category_3")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category3 { get; set; }

        [Column("category_4")] 
        [ColumnDbType("text", 0, false, "")] 
        public string Category4 { get; set; }

    }
}

