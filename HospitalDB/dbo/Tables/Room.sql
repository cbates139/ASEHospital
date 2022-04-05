CREATE TABLE [dbo].[Room] (
    RoomID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    BedCount INT  NOT NULL,
    RoomDescription VARCHAR (20) NOT NULL,
    WardID INT NOT NULL,
    CONSTRAINT FK_Room_Ward FOREIGN KEY (WardID) REFERENCES [dbo].[Ward](WardID)
);