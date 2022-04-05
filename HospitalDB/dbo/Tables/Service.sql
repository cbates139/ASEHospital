CREATE TABLE [dbo].[Service] (
    LeaderID INT NOT NULL,
    MemberID INT NOT NULL,
    CONSTRAINT FK_Service_LID FOREIGN KEY (LeaderID) REFERENCES [dbo].[Staff](StaffID),
    CONSTRAINT FK_Service_MID FOREIGN KEY (MemberID) REFERENCES [dbo].[Staff](StaffID)
);