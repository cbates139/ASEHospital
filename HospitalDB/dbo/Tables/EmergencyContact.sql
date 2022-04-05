CREATE TABLE [dbo].[EmergencyContact] (
    ContactID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    MobileNo VARCHAR(50) NOT NULL,
    Relation VARCHAR(15) NOT NULL,
    CONSTRAINT EC_Mob_UNQ UNIQUE (MobileNo)
);