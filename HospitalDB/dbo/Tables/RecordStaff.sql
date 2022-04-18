CREATE TABLE [dbo].[RecordStaff] (
    StaffID INT NOT NULL,
    RecordID INT NOT NULL,
    CONSTRAINT FK_RS_SID FOREIGN KEY (StaffID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_RS_RID FOREIGN KEY (RecordID) REFERENCES [dbo].[Record](RecordID)
);