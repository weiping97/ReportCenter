CREATE PROCEDURE [dbo].[uspCountry_SaveData]
	@Name NVARCHAR(50),
	@IsActive BIT,
	@CountryCode NVARCHAR(10),
	@CreatedDate DATETIME2

AS
	INSERT INTO dbo.Country([Name], [IsActive], [CountryCode], [CreatedDate])
	VALUES (@Name, @IsActive, @CountryCode, @CreatedDate)
RETURN 0
