-- PROGRAM NAME: ASQL PROG3070 Final Project
-- FILE NAME: KanBan Simulation System of Fog Lamp's 
-- PROGRAMMER: MONIRA SULTANA (7308182)
-- DESCRIPTION: This file runs all of the scripts for the creation of Fog Lamp's Kanban Simulation system.
-- DATE: March 30, 2017

-- CREATE DATABASE

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name='KanbanFogLamp')
BEGIN
CREATE DATABASE KanbanFogLamp;
END
GO


USE KanbanFogLamp;


-- CHECK TABLE EXISTANCE

--If the bin table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='Bin' AND type='u')
BEGIN
ALTER TABLE Bin DROP CONSTRAINT PK_Bin_BinID;
ALTER TABLE Bin DROP CONSTRAINT FK_Bin_PartID;
ALTER TABLE Bin DROP CONSTRAINT FK_Bin_WorkStationID;
DROP TABLE Bin;
END
GO

--If the TestTrays table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='TestTray' AND type='u')
BEGIN

ALTER TABLE TestTray DROP CONSTRAINT FK_TestTray_WorkStationID;
DROP TABLE TestTray;
END
GO

--If the fog lamp table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='FogLamp' AND type='u')
BEGIN
ALTER TABLE FogLamp DROP CONSTRAINT PK_FogLamp_FogLampID;
ALTER TABLE FogLamp DROP CONSTRAINT FK_FogLamp_WorkStationID;
ALTER TABLE FogLamp DROP CONSTRAINT FK_FogLamp_FogLampID;

DROP TABLE FogLamp;
END
GO

--If the parts table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='Part' AND type='u')
BEGIN
ALTER TABLE Part DROP CONSTRAINT PK_Part_PartID;
DROP TABLE Part;
END
GO

--If the Config table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='Config' AND type='u')
BEGIN
DROP TABLE Config;
END
GO

--If the Workstation table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='WorkStation' AND type='u')
BEGIN
ALTER TABLE WorkStation DROP CONSTRAINT PK_WorkStation_WorkStationID;
DROP TABLE WorkStation;
END
GO
--If the Workstation table exists we want to delete all foreign key and primary key constraints so we can build again
IF EXISTS (SELECT * FROM sys.objects WHERE name='Orders' AND type='u')
BEGIN
ALTER TABLE Orders DROP CONSTRAINT PK_Orders_OrderID;
DROP TABLE Orders;
END
GO



--create tables
CREATE TABLE Part(
	PartID VARCHAR(50) NOT NULL,
	PartName VARCHAR(50),
	PartDesc VARCHAR(100)
);
Go

CREATE TABLE Bin(
	BinID INTEGER NOT NULL IDENTITY(1,1),
	PartID VARCHAR(50),	
	Quantity INTEGER,
	WorkStationID INTEGER NOT NULL
);
GO

CREATE TABLE FogLamp(
	FogLampID VARCHAR(100) NOT NULL,
	WorkStationID INTEGER NOT NULL,
	CreationDate DATETIME NOT NULL DEFAULT GETDATE(),	
	PassedTesting BIT
);
GO


CREATE TABLE TestTray(
    TrayID INTEGER NOT NULL,
	PositionOfLamp INTEGER,
	FogLampID VARCHAR(100) NOT NULL,	
	WorkStationID INTEGER NOT NULL
);
GO

CREATE TABLE WorkStation(
	WorkStationID INTEGER NOT NULL,
	ExperienceLevel VARCHAR(50) NOT NULL
	
);
GO

CREATE TABLE Orders(
OrderID INTEGER NOT NULL IDENTITY(1,1),
OrderDate DATETIME DEFAULT GETDATE(),
Quantity INTEGER
);
GO




CREATE TABLE Config(
SimulationFactor VARCHAR(100),
CurrentValue VARCHAR(100),
DataType VARCHAR(50),
Descriptions VARCHAR(100),
DateChanged DATETIME NOT NULL DEFAULT GETDATE()
);
Go
-- ADD PRIMARY/FOREIGN KEY CONSTRAINTS

-- Add FogLamp primary key constraints to be identified in other tables
ALTER TABLE FogLamp
ADD CONSTRAINT PK_FogLamp_FogLampID PRIMARY KEY CLUSTERED(FogLampID);

GO
-- Add Part primary key constraints to be identified in other tables
ALTER TABLE Part
ADD CONSTRAINT PK_Part_PartID PRIMARY KEY CLUSTERED(PartID);
GO



-- Add Workstation primary key constraints to be identified in other tables
ALTER TABLE WorkStation
ADD CONSTRAINT PK_WorkStation_WorkStationID PRIMARY KEY CLUSTERED(WorkStationID);
GO
-- Add Bin foreign-key constraints for which part is in the bin
ALTER TABLE Bin
ADD CONSTRAINT PK_Bin_BinID PRIMARY KEY CLUSTERED(BinID);
ALTER TABLE Bin
ADD CONSTRAINT FK_Bin_PartID FOREIGN KEY (PartID) REFERENCES Part (PartID);
ALTER TABLE Bin
ADD CONSTRAINT FK_Bin_WorkStationID FOREIGN KEY (WorkStationID) REFERENCES Workstation (WorkStationID);
GO
-- Add TestTray foreign-key constraints for all the lamps that have been tested

ALTER TABLE TestTray
ADD CONSTRAINT FK_TestTray_WorkStationID FOREIGN KEY (WorkStationID) REFERENCES Workstation (WorkStationID);
GO


ALTER TABLE TestTray
ADD CONSTRAINT PK_TestTray_FogLampID PRIMARY KEY CLUSTERED(FogLampID);
GO
-- Add FogLamp foreign-key constraints for the all the parts

ALTER TABLE FogLamp
ADD CONSTRAINT FK_FogLamp_WorkStationID FOREIGN KEY (WorkStationID) REFERENCES Workstation (WorkStationID);
ALTER TABLE FogLamp
ADD CONSTRAINT FK_FogLamp_FogLampID FOREIGN KEY (FogLampID) REFERENCES TestTray (FogLampID);
GO

-- Add Orders primary key constraints to be identified in other tables
ALTER TABLE Orders
ADD CONSTRAINT PK_Orders_OrderID PRIMARY KEY CLUSTERED(OrderID);
GO



--Insert starting config data, most of these numbers were taken/interpreted from the specification document
INSERT INTO Config (SimulationFactor, CurrentValue, DataType, Descriptions) VALUES
 	('HAR01', 55, 'INTEGER', 'Harness'),
    ('REF02', 35, 'INTEGER','Reflector'),
	('HOU03', 24, 'INTEGER','Housing'),
	('LEN04', 40, 'INTEGER','Lens'),
	('BUL05', 60, 'INTEGER', 'Bulb' ),
	('BEZ06', 75, 'INTEGER', 'Bezel'),
	('TrayCapacity', 60, 'INTEGER', ''),	
	('NumOfWorkstations', 3, 'INTEGER', ''),
	('New/Rookie', 90, 'INTEGER', 'Assembly Time for new'),
	('Experienced/Normal', 60, 'INTEGER', 'Assembly Time for Experienced'),
	('V.Experienced/Super',51, 'INTEGER', 'Assembly Time for Super'),
	('TrayRunTimeMinutes', 300,  'INTEGER',''),
	('AssemblyDefectNew', 0.85, 'FLOAT', ''),
	('AssemblyDefectExperienced',0.5, 'FLOAT', ''),
	('AssemblyDefectSuper', 0.15, 'FLOAT', ''),
	('MinuteSeconds', 60, 'INTEGER',' Time Scale')
	 ;
GO


-- INSERT STARTING DATA
INSERT INTO WorkStation VALUES 
(1, 'New/Rookie'),
(2, 'Experienced/Normal'),
(3, 'V.Experienced/Super');
GO

INSERT INTO Orders ( Quantity) VALUES
( 5000),
( 2000),
( 5000);
GO


--Insert static list of Parts
INSERT INTO Part VALUES ('HAR01','Harness', 'The harness of a fog-lamp');
INSERT INTO Part VALUES ('REF02','Reflector', 'The reflector of a fog-lamp');
INSERT INTO Part VALUES ('HOU03','Housing', 'The housing of a fog-lamp');
INSERT INTO Part VALUES ('LEN04','Lens', 'The lens of a fog-lamp');
INSERT INTO Part VALUES ('BUL05','Bulb', 'The bulb of a fog-lamp');
INSERT INTO Part VALUES ('BEZ06','Bezel', 'The bezel of a fog-lamp');
GO


 

 

/*Creating Stored procedure PartRefill
 

Procedure Name:    PartRefill
Programer:    Monira Sultana 
Description:  This script contain AssembleFogLamp stored procedure that takes parts from each Bin and  generate FogLamp                            
Date:          Aplri 05, 2017

*/

USE [KanbanFogLamp]
GO
CREATE PROCEDURE PartRefill
	@workStationID INT = 0,
	@partID VARCHAR(10)

AS
BEGIN	

    DECLARE @quantity INTEGER = 0,
			@currentValue VARCHAR(10)
			
		SELECT @currentValue= CAST(CurrentValue AS FLOAT) FROM Config WHERE SimulationFactor= @partID;
		SELECT @quantity= Quantity FROM Bin WHERE PartID= @partID AND WorkStationID= @workStationID;			   
	
	    UPDATE Bin SET  Quantity=@quantity+ @currentValue WHERE WorkStationID= @workStationID AND PartID=@partID; 
   
   END
GO

   	
/*Creating Stored procedure BinFillup*/
 /*

Procedure Name:    BinFillup
Programer:    Monira Sultana 
Description:  This script contain AssembleFogLamp stored procedure that takes parts from each Bin and  generate FogLamp                            
Date:          Aplri 05, 2017

*/
USE [KanbanFogLamp]
GO
CREATE PROCEDURE BinFillup
	@workstationID INT = 0
AS
BEGIN	

   DECLARE @partID VARCHAR(50),		   
		   @quantity INT,	  
		   @error INT =0,
           @thisCount INT= 1
   DELETE FROM Bin WHERE WorkStationID= @workstationID;
	-- Create cursor
	DECLARE MY_CURSOR CURSOR 
	  LOCAL STATIC READ_ONLY FORWARD_ONLY
	FOR 
	-- Select the row we want to get
	SELECT DISTINCT PartID FROM part;

	OPEN MY_CURSOR
	FETCH NEXT FROM MY_CURSOR INTO @partID
	-- Keep looping until we find nothing in the cursor
	WHILE @@FETCH_STATUS = 0
	BEGIN 
		-- Select the capacitiy of the part from the configurations
		SELECT @quantity=CAST(CurrentValue AS FLOAT) FROM Config WHERE SimulationFactor=@partID;

		-- Insert into bin
		INSERT INTO Bin (PartID,Quantity, WorkStationID)
		VALUES (@partID,@quantity,@workStationID);

		-- Get the next row in the cursor
		FETCH NEXT FROM MY_CURSOR INTO @partID
	END
	CLOSE MY_CURSOR
	DEALLOCATE MY_CURSOR
END
GO



/*Creating Stored procedure AssembleFogLamp
 

Procedure Name:    AssembleFogLamp
Programer:    Monira Sultana 
Description:  This script contain AssembleFogLamp stored procedure that takes parts from each Bin and  generate FogLamp                            
Date:          Aplri 05, 2017

*/

USE [KanbanFogLamp]
GO
CREATE PROCEDURE AssembleFogLamp
@workstationID INT = 0
AS
BEGIN	

	--IF @workstationID=0
		--RETURN 0;
     --BEGIN TRY
   DECLARE @partsCount INT= 0,
		   @fogLampid VARCHAR(100),
		   @trayid INT=0 ,
		   @newTrayid VARCHAR(100),
		   @positionOfLamp INT =0,
		   @newPositionOfLamp VARCHAR(50),
           @binID INT =0,
		   @partID VARCHAR(50),		   
		   @quantity INT =0,
		  -- @fogCh VARCHAR(10) , 
		   @error INT =0,
           @count INT= 0
		--creat cursor
	 DECLARE MY_CURSOR CURSOR 
	 LOCAL STATIC READ_ONLY FORWARD_ONLY
	FOR 
	-- Select the row we want to get
	SELECT DISTINCT PartID FROM Bin WHERE WorkStationID= @workstationID;

	OPEN MY_CURSOR
	FETCH NEXT FROM MY_CURSOR INTO @partID
	-- Keep looping until we find nothing in the cursor
	WHILE @@FETCH_STATUS = 0
  
	BEGIN   

		SELECT @quantity= Quantity FROM Bin WHERE WorkStationID= @workstationID AND PartID=@partID;
	    UPDATE Bin SET  Quantity=@quantity-1 WHERE WorkStationID=@workstationID AND PartID=@partID; 
		
		FETCH NEXT FROM MY_CURSOR INTO @partID
	END
	   CLOSE MY_CURSOR
	   DEALLOCATE MY_CURSOR
		/* inser to testTray*/
		SELECT @count = COUNT(TrayID) FROM TestTray WHERE WorkStationID =@workStationID;		
		IF (@count <= 0) 
	    BEGIN                --there is no TrayID with the workStaionID
		    SELECT @count = COUNT(TrayID) FROM TestTray;           --check if there is any TrayID in the table
			IF(@count <=0)	                     --that means no data in the TestTray table
				
			BEGIN			
			SET @trayid=1
		    SET @newTrayid= right('00000' + cast(@trayid as varchar(6)), 6)
			
			SET @positionOfLamp=01;
			SET @newPositionOfLamp= right('0' + cast(@positionOfLamp as varchar(2)), 2)		
			
			SET @fogLampid = 'FL' +   @newTrayid +  @newPositionOfLamp;
		    
			/* INSERT to TestTray Table*/  
			INSERT INTO TestTray VALUES
			(@trayid,@positionOfLamp, @fogLampid, @workStationID)
			/* INSERT into foglamp*/
			INSERT INTO FogLamp(FogLampID, WorkStationID)
		    VALUES (@fogLampid, @workStationID);
			END
			ELSE                                        --there is other testTray with different workStationID in the table
			BEGIN
			SELECT @trayid=MAX(TrayID) FROM TestTray; 
		   
			SET @trayid =@trayid + 1;
			SET @newTrayid= right('00000' + cast(@trayid as varchar(6)), 6)
			SET @positionOfLamp= 01;
			SET @newPositionOfLamp= right('0' + cast(@positionOfLamp as varchar(2)), 2)
			SET @fogLampid = 'FL' +  @newTrayid + @newPositionOfLamp;
			
			INSERT INTO TestTray VALUES
			(@trayid, @positionOfLamp, @fogLampid, @workStationID);
			/* INSERT into foglamp*/
			INSERT INTO FogLamp(FogLampID, WorkStationID)
		    VALUES (@fogLampid, @workStationID);
			END
	 END
		                --IF (@count > 0)  that means TestTray has TrayID with same workStation
		ELSE
		BEGIN
		SELECT @trayid=MAX(TrayID) FROM TestTray WHERE WorkStationID= @workStationID;
		SET @newTrayid= right('00000' + cast(@trayid as varchar(6)), 6) 
		SELECT @positionOfLamp= MAX(PositionOfLamp) FROM TestTray WHERE WorkStationID= @workStationID AND TrayID= @trayid;
			IF(@positionOfLamp <60)
			BEGIN
			SET  @positionOfLamp = @positionOfLamp+1
			SET @newPositionOfLamp = right('0' + cast(@positionOfLamp as varchar(2)), 2)
			
			SET @fogLampid = 'FL' + @newTrayid + @newPositionOfLamp;
			
			INSERT INTO TestTray VALUES
			(@trayid, @positionOfLamp, @fogLampid, @workStationID);
			/* INSERT into foglamp*/
			INSERT INTO FogLamp(FogLampID, WorkStationID)
		    VALUES (@fogLampid, @workStationID);
			
			END
			ELSE
			BEGIN
			SELECT @trayid=MAX(TrayID) FROM TestTray; 
			SET @trayid= @trayid+1;
			SET @newTrayid= right('00000' + cast(@trayid as varchar(6)), 6)
			SET @positionOfLamp =1
			SET @newPositionOfLamp= right('0' + cast(@positionOfLamp as varchar(2)), 2)
			
			SET @fogLampid = 'FL' + @newTrayid +  @newPositionOfLamp;
			
			INSERT INTO TestTray VALUES
			(@trayid,@positionOfLamp, @fogLampid, @workStationID);
			/* INSERT into foglamp*/
			INSERT INTO FogLamp(FogLampID, WorkStationID)
		    VALUES (@fogLampid, @workStationID);		 
		END
		 
		              
	END		
		
END 
--  Quirey
--Create view to get experience level 
CREATE VIEW Full_FogLamp As
SELECT FogLamp.*, WorkStation.ExperienceLevel 
FROM FogLamp
INNER JOIN WorkStation ON FogLamp.WorkStationID=WorkStation.WorkStationID; 

--Quary for total foglamp

SELECT Count(FogLampID)AS TotalFogLamp, ExperienceLevel from Full_FogLamp
Group By ExperienceLevel;





SELECT Count (FogLampID) AS TotalFogLamp, ExperienceLevel from Full_FogLamp 
Group By ExperienceLevel

SELECT CurrentValue  FROM Config WHERE SimulationFactor= 'New/Rookie'; 




 ORDER BY WorkStationID ASC;


Group By WorkStationID ORDER BY ASC;

SELECT ExperienceLevel from WorkStation Where WorkStationID =1;

Select *from Config
  
SELECT Count(FogLampID) AS TotalFogLamp FROM FogLamp where WorkStationID =3


SELECT Count(FogLampID) AS TotalFogLamp FROM FogLamp; 
SELECT CurrentValue FROM Config WHERE Simulationfactor = 'AssemblyDefectSuper'; 

SELECT Count (FogLampID) AS TotalFogLamp, WorkStationID from FogLamp 
Group By WorkStationID

SELECT Count(FogLampID)AS TotalFogLamp, ExperienceLevel from Full_FogLamp
                  Group By ExperienceLevel;