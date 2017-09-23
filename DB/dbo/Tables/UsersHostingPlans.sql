CREATE TABLE [dbo].[UsersHostingPlans]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[UserID] INT NOT NULL,
	[HostingPlanID] INT NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[NextBillingDate] DATETIME NOT NULL,
	[Active] BIT DEFAULT(1) NOT NULL,
	CONSTRAINT [PK_UsersHostingPlans_ID] PRIMARY KEY ([ID] ASC),
	CONSTRAINT [FK_UsersHostingPlans_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users]([ID]),
	CONSTRAINT [FK_UsersHostingPlans_HostingPlans_HostingPlanID] FOREIGN KEY ([HostingPlanID]) REFERENCES [HostingPlans]([ID]),
)
