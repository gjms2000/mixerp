DO
$$
BEGIN
    IF(core.get_locale() = 'en-US') THEN
        INSERT INTO core.custom_field_data_types(data_type, is_number)
        SELECT 'Text', true;

        INSERT INTO core.custom_field_data_types(data_type, is_number)
        SELECT 'Number', true;

        INSERT INTO core.custom_field_data_types(data_type, is_date)
        SELECT 'Date', true;

        INSERT INTO core.custom_field_data_types(data_type, is_boolean)
        SELECT 'True/False', true;

        INSERT INTO core.custom_field_data_types(data_type, is_long_text)
        SELECT 'Long Text', true;


        PERFORM core.add_custom_field_form('Accounts', 'core.accounts', 'account_id');
        PERFORM core.add_custom_field_form('Items', 'core.items', 'item_id');
        PERFORM core.add_custom_field_form('Parties', 'core.parties', 'party_id');
    END IF;
END
$$
LANGUAGE plpgsql;