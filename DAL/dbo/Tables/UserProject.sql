CREATE TABLE [dbo].[UserProject]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NOT NULL, 
    [ProjectId] INT NOT NULL, 
    [IsAccessible] BIT NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [CreatedBy] NVARCHAR(128) NOT NULL, 
    [LastModifiedDate] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(128) NULL,
    CONSTRAINT [FK_UserProject_ToUser] FOREIGN KEY (UserId) REFERENCES [User](Id),
    CONSTRAINT [FK_UserProject_ToProject] FOREIGN KEY (ProjectId) REFERENCES [Project](Id)
)
