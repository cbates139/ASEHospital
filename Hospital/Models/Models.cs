using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Models
{
    public class PiiModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public PiiModel(string FirstName,
                        string LastName,
                        string MobileNo,
                        string Email,
                        DateTime Dob)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MobileNo = MobileNo;
            this.Email = Email;
            this.Dob = Dob;
        }
    }

    public class AddressModel
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public AddressModel(string AddressLine1,
                            string AddressLine2,
                            string AddressLine3,
                            string City,
                            string Region,
                            string PostCode)
        {
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AddressLine3 = AddressLine3;
            this.City = City;
            this.Region = Region;
            this.PostCode = PostCode;
        }
    }

    public class EmergencyContactModel
    {
        public string EName { get; set; }
        public string ELastName { get; set; }

        public string EMobileNumber { get; set; }
        public string ERelation { get; set; }
        public EmergencyContactModel(string EName,
                                     string ELastName,
                                     string EMobileNumber,
                                     string ERelation)
        {
            this.EName = EName;
            this.ELastName = ELastName;
            this.EMobileNumber = EMobileNumber;
            this.ERelation = ERelation;
        }
    }

}
