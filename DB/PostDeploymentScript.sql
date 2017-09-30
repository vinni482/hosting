/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DECLARE @id1 int,
		@id2 int,
		@id3 int
   
IF NOT EXISTS(SELECT * FROM HostingPlans WHERE Active = 1)
BEGIN
	  INSERT INTO HostingPlans(Name, Description, Active) VALUES('Минимум','Все необходимое для старта',1)
	  SELECT @id1 = SCOPE_IDENTITY()
	  INSERT INTO HostingPlans(Name, Description, Active) VALUES('Стандарт','Самый оптимальный пакет',1)
	  SELECT @id2 = SCOPE_IDENTITY()
	  INSERT INTO HostingPlans(Name, Description, Active) VALUES('Минимум','Отличный выбор для профессионалов',1)
	  SELECT @id3 = SCOPE_IDENTITY()

	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id1, '10 GB')
	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id1, '1 MS SQL Server')
	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id2, '20 GB')
	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id2, '2 MS SQL Server')
	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id3, '50 GB')
	  INSERT INTO Features(HostingPlanID, Name) VALUES(@id3, '5 MS SQL Server')

	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id1, 3, 99.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id1, 6, 89.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id1, 12, 79.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id1, 24, 69.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id2, 3, 109.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id2, 6, 99.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id2, 12, 89.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id2, 24, 79.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id3, 3, 129.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id3, 6, 119.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id3, 12, 109.99)
	  INSERT INTO HostingPlansPrices(HostingPlanID, Months, Price) VALUES(@id3, 24, 99.99)
END

  
  
