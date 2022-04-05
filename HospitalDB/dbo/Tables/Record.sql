CREATE TABLE [dbo].[Record] (
    RecordID INT IDENTITY(1,1) PRIMARY KEY,
    StaffID INT  NOT NULL,
    PatientID INT NOT NULL,
    RoomID INT NOT NULL,
    ReasonForVisit VARCHAR(MAX) NOT NULL,
    CONSTRAINT FK_Record_StaffID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_Record_PatientID FOREIGN KEY (PatientID) REFERENCES [dbo].[Pii](PatientID),
    CONSTRAINT FK_Record_RoomID FOREIGN KEY (RoomID) REFERENCES [dbo].[Room](RoomID)
);