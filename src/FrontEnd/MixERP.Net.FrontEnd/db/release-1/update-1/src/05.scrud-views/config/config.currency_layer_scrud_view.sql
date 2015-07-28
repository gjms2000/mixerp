CREATE VIEW config.currency_layer_scrud_view
AS
SELECT 
	key,
	value,
	description
FROM
config.currency_layer;
