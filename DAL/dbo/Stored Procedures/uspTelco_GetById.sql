CREATE PROCEDURE [dbo].[uspTelco_GetById]
	@Id INT
AS
	SELECT [Id], [Name]
	FROM [Telco]
	WHERE [Id] = @Id
RETURN 0
