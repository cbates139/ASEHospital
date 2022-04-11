-- Inherited Tables
CREATE TABLE [dbo].[AdminStaff] (
    StaffID INT  NOT NULL,
    Position VARCHAR (10)  NOT NULL,
    CONSTRAINT FK_AdminStaff_ID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID)
);