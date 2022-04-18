using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Models;
using Hospital.Utilities;

namespace Hospital.User_Controls
{
    public partial class JuniorPatientView : UserControl
    {
        public RecordModel addR { get; private set; }
        public JuniorPatientView()
        {
            InitializeComponent();
            InitialiseUserControl();
        }
        private void InitialiseUserControl()
        {
            patientDetail_panel.Visible = false;
            submitTreatment_panel.Visible = false;
            patientList_panel.Visible = false;

            selectedPatient_label.Visible = false;
            patientName_label.Visible = false;

            treatmentType_label.Visible = false;
            treatmentList_listbox.Visible = false;

            medication_label.Visible = false;
            medicationList_listbox.Visible = false;

            reasonForVisit_label.Visible = false;
            notesText_textbox.Visible = false;

            treatmentSubmit_button.Visible = false;     
        }
        private void InitialisePatientList()
        {
            //TODO: update patient list from database
        }
        private void InitialiseMedication()
        {
            medicationList_listbox.Items.Clear();
            medicationList_listbox.Items.Add("Morphine");
            medicationList_listbox.Items.Add("Oxycodone");
            medicationList_listbox.Items.Add("Buscopan");
            medicationList_listbox.Items.Add("Amitriptyline");
            medicationList_listbox.Items.Add("Tramadol");
            medicationList_listbox.Items.Add("Codeine");
            medicationList_listbox.Items.Add("Paracetamol");
        }

        private void viewPatientList_button_Click(object sender, EventArgs e)
        {
            InitialisePatientList();
            patientList_panel.Visible = true;
        }

        private void treatPatient_button_Click(object sender, EventArgs e)
        {
            if (patientList_listbox.SelectedIndex ==-1)
              MessageBox.Show("Please select a patient first!");
            else
            {
                patientName_label.Text = patientList_listbox.SelectedItem.ToString();
                patientDetail_panel.Visible = true;
                submitTreatment_panel.Visible = true;

                selectedPatient_label.Visible = true;
                patientName_label.Visible = true;

                treatmentType_label.Visible = true;
                treatmentList_listbox.Visible = true;

                medication_label.Visible = true;
                medicationList_listbox.Visible = true;

                reasonForVisit_label.Visible = true;
                notesText_textbox.Visible = true;

                treatmentSubmit_button.Visible = true;
            }
        }
        private void treatmentList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {   //Display Medication if Selected
            if (treatmentList_listbox.SelectedIndex == 0)
                InitialiseMedication();
            else
                medicationList_listbox.Items.Clear();
        }
        private void treatmentSubmit_button_Click(object sender, EventArgs e)
        {
            int StaffID = 1;
            int PatientID = 1;
            int RoomID = 1;
            string ReasonForVisit = notesText_textbox.Text;

            if (notesText_textbox.Text == "")
            {
                MessageBox.Show("Please Provide Reason For Visit");
                return;
            }else if(treatmentList_listbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Provide Treatment Type For Visit");
                return;
            }
            else if((treatmentList_listbox.SelectedIndex == 0) && (medicationList_listbox.SelectedIndex == -1))
            {
                 MessageBox.Show("Please Provide Medication For Visit");
            }
            else 
            {             
                RecordModel record = new Models.RecordModel(StaffID, PatientID, RoomID, ReasonForVisit);
                DBConnection.SubmitRecord(record);
                {   //Close Patient Treat Patient Details
                    patientDetail_panel.Visible = false;
                    submitTreatment_panel.Visible = false;

                    selectedPatient_label.Visible = false;
                    patientName_label.Visible = false;

                    treatmentType_label.Visible = false;
                    treatmentList_listbox.Visible = false;

                    medication_label.Visible = false;
                    medicationList_listbox.Visible = false;

                    reasonForVisit_label.Visible = false;
                    notesText_textbox.Visible = false;

                    treatmentSubmit_button.Visible = false;
                    patientList_listbox.SelectedIndex = -1;
                }
                MessageBox.Show("Record Submitted");
            }             
        }
    }
}