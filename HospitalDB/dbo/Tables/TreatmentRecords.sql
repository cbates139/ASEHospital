CREATE TABLE [dbo].[TreatmentRecords] (
    TreatmentID INT  NOT NULL,
    RecordID INT  NOT NULL,
    CONSTRAINT FK_TR_TreatmentID FOREIGN KEY (TreatmentID) REFERENCES [dbo].[Treatment](TreatmentID),
    CONSTRAINT FK_TR_RecordID FOREIGN KEY (RecordID) REFERENCES [dbo].[Record](RecordID)
);