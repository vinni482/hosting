CREATE TABLE [dbo].[Users_HostingPlans]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[UserID] INT NOT NULL,
	[HostingPlanID] INT NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[NextBillingDate] DATETIME NOT NULL,
	[Active] BIT DEFAULT(1) NOT NULL,
	CONSTRAINT [PK_Users_HostingPlans_ID] PRIMARY KEY ([ID] ASC),
	CONSTRAINT [FK_Users_HostingPlans_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users]([ID]),
	CONSTRAINT [FK_Users_HostingPlans_HostingPlans_HostingPlanID] FOREIGN KEY ([HostingPlanID]) REFERENCES [HostingPlans]([ID]),
)
