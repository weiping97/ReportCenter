CREATE PROCEDURE [dbo].[uspUserLookup]
	@Id NVARCHAR(128)
AS
	SELECT [Id], [FirstName], [LastName], [EmailAddress], [CreatedDate]
	FROM [dbo].[User] 
	WHERE Id = @Id
RETURN 0
