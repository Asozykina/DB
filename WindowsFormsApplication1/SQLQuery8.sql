USE [Manufacture]
GO

DECLARE	@return_value Int,
		@cost decimal(15, 3)

EXEC	@return_value = [dbo].[costDetails]
		@componentCode = 2,
		@operaionCode = 101,
		@cost = @cost OUTPUT

SELECT	@cost as N'@cost'

SELECT	@return_value as 'Return Value'

GO
