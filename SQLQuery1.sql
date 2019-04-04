create table [dbo].[User] (
[Id] INT IDENTITY (1,1) not null,
[Email] NVARCHAR (MAX) NULL,
[Password] Nvarchar (MAX) Null
CONSTRAINT  [PK_USER] PRIMARY KEY CLUSTERED ([Id] ASC));