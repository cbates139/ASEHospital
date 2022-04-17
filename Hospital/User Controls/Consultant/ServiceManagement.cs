﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Hospital.Utilities;
using Hospital.Models;

namespace Hospital.User_Controls.Consultant
{
    public partial class ServiceManagement : UserControl
    {
        public ServiceManagement()
        {
            InitializeComponent();
        }

        private StaffModel selectedJunior = null;
        private StaffModel dropDown1Prev = null;
        private StaffModel dropDown2Prev = null;

        private List<string> list1Initial = new List<string>();
        private List<string> list2Initial = new List<string>();
        private List<ServiceModel> services = new List<ServiceModel>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceManagement_Load(object sender, EventArgs e)
        {
            services = DBConnection.GetConsultantServices();

            //Load consultant dropdowns.
            List<string> consultants = new List<string>();

            services.ForEach((model) =>
            {
                consultants.Add(model.Consultant.first_name + " " + model.Consultant.last_name);
            });

            dropdownConsultant1.Items.AddRange(consultants.ToArray());
            dropdownConsultant2.Items.AddRange(consultants.ToArray());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //Something selected in listBox1.
            {
                listBox2.SelectedIndex = -1; //Deselect the other box.
                selectedJunior = (StaffModel)listBox1.SelectedItem; //Set selected junior.

                buttonToLeft.Enabled = false;
                buttonToRight.Enabled = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) //Something selected in listBox2.
            {
                listBox1.SelectedIndex = -1; //Deselect the other box.
                selectedJunior = (StaffModel)listBox2.SelectedItem; //Set selected junior.
                
                buttonToLeft.Enabled = true;
                buttonToRight.Enabled = false;
            }
        }

        private void buttonToRight_Click(object sender, EventArgs e)
        {
            int index = listBox1.FindString(selectedJunior.ToString());
            listBox1.Items.Remove(index);
            listBox2.Items.Add(selectedJunior);

            checkSaveDiff();
        }

        private void buttonToLeft_Click(object sender, EventArgs e)
        {
            int index = listBox1.FindString(selectedJunior.ToString());
            listBox1.Items.Remove(index);
            listBox2.Items.Add(selectedJunior);

            checkSaveDiff();
            
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset Box 1
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list1Initial.ToArray());
            listBox1.SelectedIndex = -1;

            //Reset Box 2
            listBox2.Items.Clear();
            listBox2.Items.AddRange(list2Initial.ToArray());
            listBox2.SelectedIndex = -1;
            //Reset Buttons
            checkSaveDiff();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //TODO: Compare Diff and save.
        }

        private void dropdownConsultant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add Juniors to list 1.
            listBox1.Items.Clear();
            ServiceModel sm = services.Find((service) => service.Consultant == (StaffModel)dropdownConsultant1.SelectedItem);
            listBox1.Items.AddRange(sm.Juniors.ToArray());

            //Hide current consultant1 in dropdown 2.
            dropdownConsultant2.Items.Remove(sm.Consultant);
            //Show previous consultant1 in dropdown 2.
            dropdownConsultant2.Items.Add(dropDown1Prev);
        }
        private void dropdownConsultant1_DropDown(object sender, EventArgs e)
        {
            dropDown1Prev = (StaffModel)dropdownConsultant1.SelectedItem; //Save previous selection.
        }
        private void dropdownConsultant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add Juniors to list 2.
            listBox2.Items.Clear();
            ServiceModel sm = services.Find((service) => service.Consultant == (StaffModel)dropdownConsultant2.SelectedItem);
            listBox2.Items.AddRange(sm.Juniors.ToArray());

            //Hide current consultant2 in dropdown 1.
            dropdownConsultant1.Items.Remove(sm.Consultant);
            //Show previous consultant2 in dropdown 1.
            dropdownConsultant1.Items.Add(dropDown2Prev);

        }

        private void dropdownConsultant2_DropDown(object sender, EventArgs e)
        {
            dropDown2Prev = (StaffModel)dropdownConsultant2.SelectedItem; //Save previous selection.
        }

        private void checkSaveDiff()
        {
            List<string> list1Current = listBox1.Items.Cast<String>().ToList();
            List<string> list2Current = listBox2.Items.Cast<String>().ToList();

            //Compare initial and current respective lists.
            bool diff = (
                list1Current.Except(list1Initial).Any()     // True if list1C contains anything that list1I doesn't have.
                || list1Initial.Except(list1Current).Any()  // True if list1I contains anything that list1C doesn't have.
                || list2Current.Except(list2Initial).Any()  // True if list2C contains anything that list2I doesn't have.
                || list2Initial.Except(list2Current).Any()  // True if list2C contains anything that list2I doesn't have.
                );


            //Enable/Disable save & reset buttons.
            buttonSave.Enabled = diff;
            buttonReset.Enabled = buttonSave.Enabled;

            //Enable/Disable Consultant selection.
            dropdownConsultant1.Enabled = !diff;
            dropdownConsultant2.Enabled = dropdownConsultant1.Enabled;
        }

    }
}