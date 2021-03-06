﻿CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[AspNetUserID] NVARCHAR(128) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Users_ID] PRIMARY KEY ([ID] ASC),
	CONSTRAINT [FK_Users_AspNetUsers_AspNetUserID] FOREIGN KEY ([AspNetUserID]) REFERENCES [AspNetUsers]([Id]),
)
