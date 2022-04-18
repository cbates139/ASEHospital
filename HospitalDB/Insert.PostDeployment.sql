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
-- Dylan's Dummy Data
-- Yeah all staff live at the same address because I'm lazy.
DELETE FROM [dbo].[Service];
DELETE FROM [dbo].[Staff];

DELETE FROM [dbo].[Pii];
DELETE FROM [dbo].[EmergencyContact];

DELETE FROM [dbo].[Room];
DELETE FROM [dbo].[Ward];
DELETE FROM [dbo].[Building];
DELETE FROM [dbo].[Address];
DELETE FROM [dbo].[Medication];


DBCC CHECKIDENT ('Staff', RESEED, 0);
DBCC CHECKIDENT ('Address', RESEED, 0);
DBCC CHECKIDENT ('Medication', RESEED, 0);
DBCC CHECKIDENT ('Building', RESEED, 0);
DBCC CHECKIDENT ('Ward', RESEED, 0);
DBCC CHECKIDENT ('Room', RESEED, 0);
DBCC CHECKIDENT ('EmergencyContact', RESEED, 0);
DBCC CHECKIDENT ('Pii', RESEED, 0);

INSERT INTO [dbo].[Address] (
    AddressLine1,
    City,
    Region,
    PostCode
)
VALUES
    (
        '1 Arundel Street',
        'Sheffield',
        'South Yorkshire',
        'ABC DE'
    );

-- A bunch of staff accounts.
INSERT INTO [dbo].[Staff] (
    FirstName,
    LastName,
    Email,
    AddressID
)
VALUES (
        'Alice',
        'Adams',
        'a.adams@mail.com',
        1
    ),
    (
        'Bob',
        'Beckett',
        'b.beckett@mail.com',
        1
    ),
    (
        'Charlie',
        'Chaplain',
        'c.omedy@mail.com',
        1
    ),
    (
        'Derren',
        'Icks',
        'd.icks@mail.com',
        1
    ),
    (
        'Eleanor',
        'Jit',
        'e.jit@mail.com',
        1
    ),
    (
        'Franklain',
        'Uckle',
        'f.uckle@mail.com',
        1
    ),
    (
        'Gary',
        'Glitter',
        'g.glitter@mail.com',
        1
    ),
    (
        'Harry',
        'Hill',
        'h.hill@mail.com',
        1
    ),
    (
        'Ida',
        'Smirnoff',
        'i.smirnoff@mail.com',
        1
    );

-- Services
INSERT INTO [dbo].[Service] (
    LeaderID,
    MemberID
)
VALUES
    ( 1,4 ),
    ( 1,5 ),
    ( 2,6 ),
    ( 2,7 ),
    ( 3,8 ),
    ( 3,9 );

-- Matthew's Dummy Data
INSERT INTO [dbo].Medication(
   MedicationName
)
VALUES
    (
        'Morphine'
    ),
  (
        'Oxycodone'
    ),
  (
        'Buscopan'
    ),
  (
        'Amitriptyline'
    ),
  (
        'Tramadol'
    ),
  (
        'Codeine'
    ),
(
        'Paracetamol'
    );
INSERT INTO [dbo].Building(
   AddressID,
   BuildingName
)
VALUES
    (
        '1',
        'Hospital ASE'
    );
INSERT INTO [dbo].Ward(
   WardDescription,
   Specialty,
   BuildingID
)
VALUES
    (
        'diagnose, assess and treat patients with defects and diseases of the heart and the blood vessels',
        'Cardiology',
        '1'
    );
INSERT INTO [dbo].Room(
   BedCount,
   RoomDescription,
   WardID
)
VALUES
    (
        '4',
        'Special Equipment',
        '1'
    );