--Empty
DO
$$
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'filters'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.filters
        (
            filter_id               BIGSERIAL NOT NULL PRIMARY KEY,
            object_name             text NOT NULL,
            filter_name             text NOT NULL,
            is_default              boolean NOT NULL DEFAULT(false),
            is_default_admin        boolean NOT NULL DEFAULT(false),
            column_name             text NOT NULL,
            filter_condition        integer NOT NULL,
            filter_value            text,
            filter_and_value        text
        );

        CREATE INDEX filters_object_name_inx
        ON core.filters(object_name);
    END IF;    
END
$$
LANGUAGE plpgsql;
