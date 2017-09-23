CREATE TABLE [dbo].[HostingPlansPrices]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[HostingPlanID]	INT NOT NULL,
	[Months] INT NOT NULL,
	[Price] SMALLMONEY NOT NULL,
	CONSTRAINT [PK_HostingPlansPrices_ID] PRIMARY KEY ([ID] ASC),
	CONSTRAINT [FK_HostingPlansPrices_HostingPlans_HostingPlanID] FOREIGN KEY ([HostingPlanID]) REFERENCES [HostingPlans]([ID]),
)
