USE [BikeStore]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[ListarÓrdenes]
		@desde = '2022-01-01',
		@hasta = '2022-01-31'

SELECT	'Return Value' = @return_value

GO
