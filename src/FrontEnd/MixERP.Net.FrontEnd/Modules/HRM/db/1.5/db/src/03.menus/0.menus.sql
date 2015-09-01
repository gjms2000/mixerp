--This table should not be localized.

SELECT * FROM core.create_menu('HRM', '~/Modules/HRM/Index.mix', 'SA', 0, NULL);
SELECT * FROM core.create_menu('Tasks', NULL, 'HRMTA', 1, core.get_menu_id('HRM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Tasks/.mix', '', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Tasks/.mix', '', 2, core.get_menu_id('HRMTA'));

SELECT * FROM core.create_menu('Setup & Maintenance', NULL, 'HRMSSM', 1, core.get_menu_id('HRM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Setup/.mix', '', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Setup/.mix', '', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Setup/.mix', '', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/Setup/.mix', '', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.create_menu('HRM Reports', NULL, 'HRMRPT', 1, core.get_menu_id('HRM'));
SELECT * FROM core.create_menu('', '~/Modules/HRM/.mix', 'IIM', 1, core.get_menu_id('HRMRPT'));
