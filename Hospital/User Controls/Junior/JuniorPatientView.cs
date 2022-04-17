using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.User_Controls
{
    public partial class JuniorPatientView : UserControl
    {
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
            dataGridView1.Visible = false;

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
            //TODO: update medication from database
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel13_Paint(object sender, PaintEventArgs e)
        {

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
                dataGridView1.Visible = true;

                reasonForVisit_label.Visible = true;
                notesText_textbox.Visible = true;

                treatmentSubmit_button.Visible = true;

            }
        }
        
        private void treatmentList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = treatmentList_listbox.SelectedItem.ToString();
            //Display Medication if Selected
            if (curItem == "Medication")
                InitialiseMedication();

        }
        private void treatmentSubmit_button_Click(object sender, EventArgs e)
        {
            /*
            if(validation)
            {
                //TODO: Submit data to database - validate
                {
                    patientDetail_panel.Visible = false;
                    submitTreatment_panel.Visible = false;

                    selectedPatient_label.Visible = false;
                    patientName_label.Visible = false;

                    treatmentType_label.Visible = false;
                    treatmentList_listbox.Visible = false;

                    medication_label.Visible = false;
                    dataGridView1.Visible = false;

                    notes_label.Visible = false;
                    notesText_textbox.Visible = false;

                    treatmentSubmit_button.Visible = false;
                }
                MessageBox.Show("Record Submitted");
            }
            else
            {
                MessageBox.Show("Error With Data");
            }
             */
        }

    }
}
