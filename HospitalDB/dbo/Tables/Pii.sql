-- Secondary Tables
-- Secondary Tables
CREATE TABLE [dbo].[Pii] (
    PatientID INT  NOT NULL PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    Dob DATETIME NOT NULL,
    MobileNo VARCHAR(50) NULL,
    Email VARCHAR (20) NULL,
    CONSTRAINT P_Email_UNQ UNIQUE (Email),
    CONSTRAINT P_Mob_UNQ UNIQUE (MobileNo)
);