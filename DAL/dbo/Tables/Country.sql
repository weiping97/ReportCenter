CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [IsActive] BIT NULL, 
    [CountryCode] NVARCHAR(10) NULL, 
    [CreatedDate] DATETIME2 NULL
)
