-- Primary tables

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