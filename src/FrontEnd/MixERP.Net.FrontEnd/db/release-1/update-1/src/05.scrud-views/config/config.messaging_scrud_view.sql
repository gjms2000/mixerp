DROP VIEW IF EXISTS config.messaging_scrud_view;

CREATE VIEW config.messaging_scrud_view
AS
SELECT 
	key,
	value
FROM
config.messaging;
