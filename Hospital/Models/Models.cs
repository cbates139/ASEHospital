using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Models
{
    public class PiiModel
    {
        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }

    }

    public class AddressModel
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
    }

    public class RecordModel
    {
        public int StaffID { get; set; }
        public int PatientID { get; set; }
        public int RoomID { get; set; }
        public string ReasonForVisit { get; set; }
        public RecordModel(int StaffID, int PatientID, int RoomID, string ReasonForVisit)
        {
            this.StaffID = StaffID;
            this.PatientID = PatientID;
            this.RoomID = RoomID;
            this.ReasonForVisit = ReasonForVisit;
        }
    }
}
