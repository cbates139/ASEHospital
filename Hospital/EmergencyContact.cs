using Hospital.Models;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Hospital.Utilities.DBConnection;
using System.Data.SqlClient;
using System.Globalization;

namespace Hospital
{
    public partial class EmergencyContact : Form
    {
        public PiiModel PiiM { get; private set; }
        public AddressModel addM { get; private set; }
        public EmergencyContactModel ECM { get; private set; }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=HospitalDB;Integrated Security=True");


        public EmergencyContact()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string EFirstName = tbEName.Text;
            string ELastName = tbELastName.Text;
            string EMobileNumber = tbEMobileNumber.Text;
            string ERelation = tbERelation.Text;
            if(String.IsNullOrWhiteSpace(EFirstName) ||
               String.IsNullOrWhiteSpace(ELastName) ||
               String.IsNullOrWhiteSpace(EMobileNumber)||
               String.IsNullOrWhiteSpace(ERelation))
            {
                MessageBox.Show("All the fields must be filled.");
                return;
            }
            else if (EMobileNumber.Length != 11)
            {
                MessageBox.Show("Provide Valid Phone Number.");
                return;
            }
            else
            {
                int AddressId;
                int EmergencyContactId;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Address(AddressLine1,AddressLine2,AddressLine3,City,Region,PostCode)values('" + addM.AddressLine1 + "','" + addM.AddressLine2 + "','" + addM.AddressLine3 + "','" + addM.City + "','" + addM.Region + "','" + addM.PostCode + "')SELECT SCOPE_IDENTITY() ", con);
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO EmergencyContact(FirstName,LastName,MobileNo,Relation)values('" + EFirstName + "','" + ELastName + "','" + EMobileNumber + "','" + ERelation + "')SELECT SCOPE_IDENTITY() ", con);
                    AddressId = Convert.ToInt32(cmd.ExecuteScalar());
                    EmergencyContactId = Convert.ToInt32(cmd1.ExecuteScalar());
                    string format = "yyyy-MM-dd HH:mm:ss";
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Pii(FirstName,LastName,Dob,MobileNo,Email,AddressID,ContactID)values('" + PiiM.FirstName + "','" + PiiM.LastName + "','" + PiiM.Dob.ToString(format) + "','" + PiiM.MobileNo + "','" + PiiM.Email + "','" + AddressId + "','" + EmergencyContactId + "')", con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
        }

        private void tbEMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbEMobileNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbEMobileNumber.Text = tbEMobileNumber.Text.Remove(tbEMobileNumber.Text.Length - 1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string EFirstName = tbEName.Text;
            string ELastName = tbELastName.Text;
            string EMobileNumber = tbEMobileNumber.Text;
            string ERelation = tbERelation.Text;
            EmergencyContactModel emergencyContactModel = new EmergencyContactModel(EFirstName, ELastName, EMobileNumber, ERelation);
            Address address = new Address();
            this.Hide();
            PiiModel tempmPii = this.PiiM;
            AddressModel tempAddress = this.addM;
            address.ShowDialog( ref tempmPii, ref tempAddress,ref emergencyContactModel);
        }
        public void ShowDialog(ref Models.PiiModel pii, ref Models.AddressModel add, ref Models.EmergencyContactModel ecm)
        {
            if (ecm != null)
            {
                this.tbEName.Text = ecm.EName;
                this.tbELastName.Text = ecm.ELastName;
                this.tbEMobileNumber.Text = ecm.EMobileNumber;
                this.tbERelation.Text = ecm.ERelation;
            }
            this.PiiM = pii;
            this.addM = add;
            this.ECM = ecm;
            this.ShowDialog();
        }

    }
}
