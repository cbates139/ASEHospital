-- Linking Tables 
-- Linking Tables 
CREATE TABLE [dbo].[TreatmentMedications] (
    TreatmentID INT  NOT NULL,
    MedicationID INT  NOT NULL,
    Dosage VARCHAR(10)  NOT NULL,
    CONSTRAINT FK_TM_TreatmentID FOREIGN KEY (TreatmentID) REFERENCES [dbo].[Treatment](TreatmentID),
    CONSTRAINT FK_TM_MedicationID FOREIGN KEY (MedicationID) REFERENCES [dbo].[Medication](MedicationID)
);