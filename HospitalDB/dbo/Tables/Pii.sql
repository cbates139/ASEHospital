-- Secondary Tables
CREATE TABLE [dbo].[Pii] (
    PatientID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    Dob DATETIME NOT NULL,
    MobileNo VARCHAR(50) NULL,
    Email VARCHAR (20) NULL,
    CONSTRAINT P_Email_UNQ UNIQUE (Email),
    CONSTRAINT P_Mob_UNQ UNIQUE (MobileNo),
    AddressID INT NOT NULL,
    ContactID INT NOT NULL,
    CONSTRAINT FK_Pii_Address FOREIGN KEY (AddressID) REFERENCES [dbo].[Address](AddressID),
    CONSTRAINT FK_Pii_EC FOREIGN KEY (ContactID) REFERENCES [dbo].[EmergencyContact](ContactID)

);