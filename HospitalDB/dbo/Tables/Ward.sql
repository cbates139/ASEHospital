CREATE TABLE [dbo].[Ward] (
    WardID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    WardDescription VARCHAR (120)  NOT NULL,
    Specialty VARCHAR (20) NOT NULL,
    BuildingID INT NOT NULL,
    CONSTRAINT FK_Ward_Address FOREIGN KEY (BuildingID) REFERENCES [dbo].[Building](BuildingID)
);