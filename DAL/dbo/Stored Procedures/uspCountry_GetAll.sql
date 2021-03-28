CREATE PROCEDURE [dbo].[uspCountry_GetAll]
	
AS
	SELECT [Id], [Name], [IsActive], [CountryCode], [CreatedDate]
	FROM Country
RETURN 0
