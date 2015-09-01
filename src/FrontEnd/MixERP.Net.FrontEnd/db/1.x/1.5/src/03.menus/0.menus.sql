--This table should not be localized.
SELECT * FROM core.create_menu('Other Setup', NULL, 'OTHR', 1, core.get_menu_id('SET'));
SELECT * FROM core.create_menu('Genders', '~/Modules/BackOffice/Other/Genders.mix', 'GENDR', 2, core.get_menu_id('OTHR'));
SELECT * FROM core.create_menu('Identification Types', '~/Modules/BackOffice/Other/IdentificationTypes.mix', 'IDNTYP', 2, core.get_menu_id('OTHR'));
SELECT * FROM core.create_menu('Nationalities', '~/Modules/BackOffice/Other/Nationalities.mix', 'NTNALY', 2, core.get_menu_id('OTHR'));

SELECT * FROM core.create_menu('Default Entity Access Policy', '~/Modules/BackOffice/Policy/DefaultEntityAccess.mix', 'DEFEAPOL', 2, core.get_menu_id('SPM'));
SELECT * FROM core.create_menu('Entity Access Policy', '~/Modules/BackOffice/Policy/EntityAccess.mix', 'EAPOL', 2, core.get_menu_id('SPM'));
