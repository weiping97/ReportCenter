CREATE PROCEDURE [dbo].[uspCountry_GetById]
	@Id INT
AS
	SELECT [Id], [Name], [IsActive], [CountryCode], [CreatedDate]
	FROM [dbo].[Country] WHERE [Id] = @Id
RETURN 0
