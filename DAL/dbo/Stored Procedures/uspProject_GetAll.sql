CREATE PROCEDURE [dbo].[uspProject_GetAll]
AS
	SELECT P.[Id], P.[Name], P.[CreatedDate], C.[Id] AS CountryId, C.[Name] AS CountryName, P.IsActive
	FROM [dbo].[Project] P
	JOIN [dbo].[Country] C ON P.CountryId = C.Id
RETURN 0
