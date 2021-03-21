﻿CREATE TABLE [dbo].[Report]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectId] INT NOT NULL, 
    [URL] NVARCHAR(300) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [CreatedBy] NVARCHAR(128) NOT NULL, 
    [LastModifiedDate] DATETIME2 NULL, 
    [LastModifiedBy] DATETIME2 NULL, 
    [ReportTypeId] INT NOT NULL
)
