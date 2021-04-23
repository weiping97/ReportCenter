CREATE PROCEDURE [dbo].[uspCountry_SaveData]
	@Name NVARCHAR(50),
	@CountryCode NVARCHAR(10)

AS
	INSERT INTO dbo.Country([Name], [IsActive], [CountryCode], [CreatedDate])
	VALUES (@Name, 1, @CountryCode, GETUTCDATE())
RETURN 0
