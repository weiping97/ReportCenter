CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(10000, 1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [CountryId] INT NOT NULL, 
    [LastModifiedDate] DATETIME2 NULL, 
    [IsActive] BIT NOT NULL, 
    [ModifiedBy] NVARCHAR(128) NULL, 
    [CreatedBy] NVARCHAR(128) NOT NULL
)
