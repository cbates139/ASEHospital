CREATE TABLE [dbo].[DoctorStaff] (
    StaffID INT  NOT NULL,
    Position VARCHAR(10) NOT NULL,
    Specialty VARCHAR(20) NULL, 
    CONSTRAINT FK_DoctorStaff_ID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID)
);