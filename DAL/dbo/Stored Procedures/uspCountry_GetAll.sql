CREATE PROCEDURE [dbo].[uspCountry_GetAll]
	
AS
	SELECT [Name], [IsActive], [CountryCode], [CreatedDate]
	FROM Country
RETURN 0
