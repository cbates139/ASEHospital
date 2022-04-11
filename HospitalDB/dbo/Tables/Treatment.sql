CREATE TABLE [dbo].[Treatment] (
    TreatmentID INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TreatmentDescription VARCHAR (MAX)  NOT NULL,
    TreatmentDate DATETIME NOT NULL
);