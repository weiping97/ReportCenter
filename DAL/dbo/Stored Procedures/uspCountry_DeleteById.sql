CREATE PROCEDURE [dbo].[uspCountry_DeleteById]
	@Id int
AS
	UPDATE [dbo].[Country]
	SET [IsActive] = 0
	WHERE [Id] = @Id
RETURN 0
