CREATE PROCEDURE [dbo].[uspCountry_UpdateData]
	@Id INT,
	@Name NVARCHAR(50),
	@IsActive BIT,
	@CountryCode NVARCHAR(10)
AS
	UPDATE [Country]
	SET [Name] = @Name,
		[IsActive] = @IsActive,
		[CountryCode] = @CountryCode
	WHERE [Id] = @Id
RETURN 0
