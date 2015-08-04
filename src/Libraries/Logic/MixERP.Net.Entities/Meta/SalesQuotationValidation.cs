using System;
using MixERP.Net.Entities.Contracts;
using PetaPoco;

namespace MixERP.Net.Entities.Meta
{
    [TableName("public.sales_quotation_validation")]
    [PrimaryKey("tran_id", autoIncrement = false)]
    [ExplicitColumns]
    public class SalesQuotationValidation : PetaPocoDB.Record<SalesQuotationValidation>, IPoco
    {
        [Column("tran_id")]
        public long TranId { get; set; }

        [Column("validation_id")]
        public string ValidationId { get; set; }

        [Column("catalog")]
        public string Catalog { get; set; }

        [Column("valid_till")]
        public DateTime ValidTill { get; set; }

        [Column("added_on")]
        public DateTime AddedOn { get; set; }

        [Column("accepted")]
        public bool Accepted { get; set; }

        [Column("accepted_on")]
        public DateTime? AcceptedOn { get; set; }

        public static void CreateTable()
        {
            const string sql = @"DO
                                $$
                                BEGIN
                                    IF NOT EXISTS (
                                        SELECT 1 
                                        FROM   pg_catalog.pg_class c
                                        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
                                        WHERE  n.nspname = 'public'
                                        AND    c.relname = 'sales_quotation_validation'
                                        AND    c.relkind = 'r'
                                    ) THEN
                                        CREATE TABLE public.sales_quotation_validation
                                        (
                                            tran_id                 bigint NOT NULL PRIMARY KEY,
                                            validation_id           text NOT NULL UNIQUE,
                                            catalog                 text NOT NULL,
                                            added_on                TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT(NOW()),
                                            valid_till              TIMESTAMP WITH TIME ZONE NOT NULL,
                                            accepted                boolean NOT NULL DEFAULT(false),
                                            accepted_on             TIMESTAMP WITH TIME ZONE
                                        );
                                    END IF;
                                END
                                $$
                                LANGUAGE plpgsql;
                                ";

            Factory.NonQuery(Factory.MetaDatabase, sql);
        }
    }
}