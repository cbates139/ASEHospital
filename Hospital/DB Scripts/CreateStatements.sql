-- Primary tables

CREATE TABLE [dbo].[Address] (
    AddressID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    AddressLine1 VARCHAR (MAX)  NOT NULL,
    AddressLine2 VARCHAR (30) NULL,
    AddressLine3 VARCHAR(30) NULL,
    City VARCHAR(50) NOT NULL,
    Region VARCHAR(40) NOT NULL,
    PostCode VARCHAR(10) NOT NULL,
);
CREATE TABLE [dbo].[Medication] (
    MedicationID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MedicationName VARCHAR (30)  NOT NULL
);
CREATE TABLE [dbo].[Treatment] (
    TreatmentID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TreatmentDescription VARCHAR (MAX)  NOT NULL,
    TreatmentDate DATETIME NOT NULL
);
CREATE TABLE [dbo].[EmergencyContact] (
    ContactID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    MobileNo VARCHAR(50) NOT NULL,
    Relation VARCHAR(15) NOT NULL,
    CONSTRAINT EC_Mob_UNQ UNIQUE (MobileNo)
);

-- Secondary Tables
CREATE TABLE [dbo].[Pii] (
    PatientID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    Dob DATETIME NOT NULL,
    MobileNo VARCHAR(50) NULL,
    Email VARCHAR (20) NULL,
    CONSTRAINT P_Email_UNQ UNIQUE (Email),
    CONSTRAINT P_Mob_UNQ UNIQUE (MobileNo)
);
CREATE TABLE [dbo].[Staff] (
    StaffID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    Email VARCHAR (20) NULL,
    AddressID INT NOT NULL,
    CONSTRAINT S_Email_UNQ UNIQUE (Email),
    CONSTRAINT FK_Staff_Address FOREIGN KEY (AddressID) REFERENCES [dbo].[Address](AddressID)
);
CREATE TABLE [dbo].[Building] (
    BuildingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    AddressID INT  NOT NULL,
    BuildingName VARCHAR (50) NOT NULL,
    CONSTRAINT B_Name_UNQ UNIQUE (BuildingName),
    CONSTRAINT FK_Building_Address FOREIGN KEY (AddressID) REFERENCES [dbo].[Address](AddressID)
);
CREATE TABLE [dbo].[Ward] (
    WardID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    WardDescription VARCHAR (50)  NOT NULL,
    Specialty VARCHAR (20) NOT NULL,
    BuildingID INT NOT NULL,
    CONSTRAINT FK_Ward_Address FOREIGN KEY (BuildingID) REFERENCES [dbo].[Building](BuildingID)
);
CREATE TABLE [dbo].[Room] (
    RoomID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    BedCount INT  NOT NULL,
    RoomDescription VARCHAR (20) NOT NULL,
    WardID INT NOT NULL,
    CONSTRAINT FK_Room_Ward FOREIGN KEY (WardID) REFERENCES [dbo].[Ward](WardID)
);
CREATE TABLE [dbo].[Record] (
    RecordID INT IDENTITY(1,1) PRIMARY KEY,
    StaffID INT  NOT NULL,
    PatientID INT NOT NULL,
    RoomID INT NOT NULL,
    ReasonForVisit VARCHAR(MAX) NOT NULL,
    CONSTRAINT FK_Record_StaffID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_Record_PatientID FOREIGN KEY (PatientID) REFERENCES [dbo].[Pii](PatientID),
    CONSTRAINT FK_Record_RoomID FOREIGN KEY (RoomID) REFERENCES [dbo].[Room](RoomID)
);

-- Inherited Tables
CREATE TABLE [dbo].[AdminStaff] (
    StaffID INT  NOT NULL,
    Position VARCHAR (10)  NOT NULL,
    CONSTRAINT FK_AdminStaff_ID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID)
);
CREATE TABLE [dbo].[DoctorStaff] (
    StaffID INT  NOT NULL,
    Position VARCHAR(10) NOT NULL,
    Specialty VARCHAR(20) NULL, 
    CONSTRAINT FK_DoctorStaff_ID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID)
);
-- Linking Tables 
CREATE TABLE [dbo].[TreatmentMedications] (
    TreatmentID INT  NOT NULL,
    MedicationID INT  NOT NULL,
    Dosage VARCHAR(10)  NOT NULL,
    CONSTRAINT FK_TM_TreatmentID FOREIGN KEY (TreatmentID) REFERENCES [dbo].[Treatment](TreatmentID),
    CONSTRAINT FK_TM_MedicationID FOREIGN KEY (MedicationID) REFERENCES [dbo].[Medication](MedicationID)
);
CREATE TABLE [dbo].[TreatmentRecords] (
    TreatmentID INT  NOT NULL,
    RecordID INT  NOT NULL,
    CONSTRAINT FK_TR_TreatmentID FOREIGN KEY (TreatmentID) REFERENCES [dbo].[Treatment](TreatmentID),
    CONSTRAINT FK_TR_RecordID FOREIGN KEY (RecordID) REFERENCES [dbo].[Record](RecordID)
);

CREATE TABLE [dbo].[Service] (
    LeaderID INT NOT NULL,
    MemberID INT NOT NULL,
    CONSTRAINT FK_Service_LID FOREIGN KEY (LeaderID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_Service_MID FOREIGN KEY (MemberID) REFERENCES [dbo].[Staff](StaffID)
);

CREATE TABLE [dbo].[RecordStaff] (
    StaffID INT NOT NULL,
    RecordID INT NOT NULL,
    CONSTRAINT FK_RS_SID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_RS_RID FOREIGN KEY (RecordID) REFERENCES [dbo].[Record](RecordID)
);


-- Dylan's Dummy Data
-- Yeah all staff live at the same address because I'm lazy.
DELETE FROM Service WHERE LeaderID=LeaderID
DELETE FROM Staff WHERE StaffID=StaffID
DELETE FROM Address WHERE AddressID=AddressID
DBCC CHECKIDENT ('Address', RESEED, 0);
DBCC CHECKIDENT ('Staff', RESEED, 0);
DBCC CHECKIDENT ('Service', RESEED, 0);

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
   Speciality,
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