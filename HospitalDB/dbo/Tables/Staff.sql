CREATE TABLE [dbo].[Staff] (
    StaffID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR (20)  NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    Email VARCHAR (20) NULL,
    AddressID INT NOT NULL,
    CONSTRAINT S_Email_UNQ UNIQUE (Email),
    CONSTRAINT FK_Staff_Address FOREIGN KEY (AddressID) REFERENCES [dbo].[Address](AddressID)
);