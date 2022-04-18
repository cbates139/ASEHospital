using Hospital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Address : Form
    {
        public PiiModel PiiM { get; private set; }
        public AddressModel addM { get; private set; }
        public EmergencyContactModel ECM { get; private set; }

        public Address()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string AddressLine1 = tbAddressLine1.Text;
            string AddressLine2 = tbAddressLine2.Text;
            string AddressLine3 = tbAddressLine3.Text;
            string City = tbCity.Text;
            string Region = tbRegion.Text;
            string Postcode = tbPostcode.Text;
            if (String.IsNullOrWhiteSpace(AddressLine1) ||
                String.IsNullOrWhiteSpace(City) ||
                String.IsNullOrWhiteSpace(Postcode))
            {
                MessageBox.Show("All the fields with star (*) must be filled.");
            }
            else
            {
                AddressModel add = new AddressModel(AddressLine1, AddressLine2, AddressLine3, City, Region, Postcode);
                PiiModel tempPii = this.PiiM;
                EmergencyContactModel tempEmergencyContactModel = this.ECM;
                EmergencyContact EC = new EmergencyContact();
                this.Hide();
                EC.ShowDialog(ref tempPii, ref add, ref tempEmergencyContactModel);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string AddressLine1 = tbAddressLine1.Text;
            string AddressLine2 = tbAddressLine2.Text;
            string AddressLine3 = tbAddressLine3.Text;
            string City = tbCity.Text;
            string Region = tbRegion.Text;
            string Postcode = tbPostcode.Text;
            AddressModel add = new AddressModel(AddressLine1, AddressLine2, AddressLine3, City, Region, Postcode);
            RegisterPation RP = new RegisterPation();
            this.Hide();
            PiiModel tempmPii = this.PiiM;
            EmergencyContactModel tempemergencyContactModel = this.ECM;
            RP.ShowDialog(ref tempmPii, ref add, ref tempemergencyContactModel);
        }
        public void ShowDialog(ref Models.PiiModel pii, ref Models.AddressModel ad, ref Models.EmergencyContactModel ecm)
        {
            if (ad != null)
            {
                this.tbAddressLine1.Text = ad.AddressLine1;
                this.tbAddressLine2.Text = ad.AddressLine2;
                this.tbAddressLine3.Text = ad.AddressLine3;
                this.tbCity.Text = ad.City;
                this.tbRegion.Text = ad.Region;
                this.tbPostcode.Text = ad.PostCode;
            }
            this.PiiM = pii;
            this.addM = ad;
            this.ECM = ecm;
            this.ShowDialog();
        }
    }
}
