CREATE TABLE [dbo].[Features]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[HostingPlanID] INT NOT NULL,
	[Name] NVARCHAR(100) NOT NULL,
	CONSTRAINT [PK_Features_ID] PRIMARY KEY ([ID] ASC),
	CONSTRAINT [FK_Features_HostingPlans_HostingPlanID] FOREIGN KEY ([HostingPlanID]) REFERENCES [HostingPlans]([ID]),
)
