CREATE TABLE [dbo].[Building] (
    BuildingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    AddressID INT  NOT NULL,
    BuildingName VARCHAR (50) NOT NULL,
    CONSTRAINT B_Name_UNQ UNIQUE (BuildingName),
    CONSTRAINT FK_Building_Address FOREIGN KEY (AddressID) REFERENCES [dbo].[Address](AddressID)
);