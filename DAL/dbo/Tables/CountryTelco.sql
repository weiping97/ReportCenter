CREATE TABLE [dbo].[CountryTelco]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CountryId] INT NOT NULL, 
    [TelcoId] INT NOT NULL, 
    [InternalTelcoId] INT NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [LastModifiedDATE] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(128) NOT NULL, 
    [LastModifiedBy] NVARCHAR(128) NULL ,
    CONSTRAINT [FK_CountryTelco_ToCountry] FOREIGN KEY (CountryId) REFERENCES [Country](Id),
    CONSTRAINT [FK_CountryTelco_ToTelco] FOREIGN KEY (TelcoId) REFERENCES [Telco](Id)
)
