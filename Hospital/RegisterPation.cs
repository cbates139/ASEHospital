using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Models;


namespace Hospital
{
    public partial class RegisterPation : Form
    {
        public PiiModel PiiM { get; private set; }
        public AddressModel addM { get; private set; }
        public EmergencyContactModel ECM { get; private set; }
        public RegisterPation()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string MobileNumber = tbMobileNumber.Text;
            string EmailAddress = tbEmailAddress.Text;
            DateTime DateOfBirth = dtDateOfBirth.Value;
            int result = DateTime.Compare(DateOfBirth, DateTime.Today);

            //Validation 
            if (String.IsNullOrWhiteSpace(FirstName)||
                String.IsNullOrWhiteSpace(LastName)||
                String.IsNullOrWhiteSpace(MobileNumber)||
                String.IsNullOrWhiteSpace(EmailAddress)
                )
            {
                MessageBox.Show("All the fields must be filled.");
                return;
            }
            else if(result > 0)
            {
                MessageBox.Show("Provide Valid Date of Birth.");
                return;
            }
            else if(MobileNumber.Length != 11)
            {
                MessageBox.Show("Provide Valid Phone Number.");
                return;
            }
            else if (!EmailAddress.Contains('@')|| !EmailAddress.Contains('.'))
            {
                MessageBox.Show("Provide Valid Email Address.");
                return;
            }
            else
            {
                PiiModel MP = new Models.PiiModel(FirstName,LastName,MobileNumber,EmailAddress,DateOfBirth);
                Address address = new Address();
                AddressModel tempAdd = this.addM;
                EmergencyContactModel tempEmergencyContactModel = this.ECM;
                this.Hide();
                address.ShowDialog(ref MP, ref tempAdd, ref tempEmergencyContactModel);
            }
        }

        private void tbMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMobileNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbMobileNumber.Text = tbMobileNumber.Text.Remove(tbMobileNumber.Text.Length - 1);
            }
        }
        public void ShowDialog(ref Models.PiiModel pii, ref Models.AddressModel add, ref Models.EmergencyContactModel ecm)
        {
            if (pii != null)
            {
                this.tbFirstName.Text = pii.FirstName;
                this.tbLastName.Text = pii.LastName;
                this.tbMobileNumber.Text = pii.MobileNo;
                this.tbEmailAddress.Text = pii.Email;
                this.dtDateOfBirth.Value = pii.Dob;
            }
            this.PiiM = pii;
            this.addM = add;
            this.ECM = ecm;
            this.ShowDialog();
        }

    }
}
