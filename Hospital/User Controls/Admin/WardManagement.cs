using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Utilities;
using Hospital.Models;

namespace Hospital.User_Controls.Admin
{
    public partial class WardManagement : UserControl
    {
        public WardManagement()
        {
            InitializeComponent();
        }

        private WardModel wm = null;
        private BuildingModel bm = null;
        private readonly List<WardModel> wards = new List<WardModel>();
        private readonly List<BuildingModel> buildings = new List<BuildingModel>();
        private void WardManagement_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
         private void RefreshData()
         {
            wards.Clear();
            buildings.Clear();
            wm = null;
            wards.AddRange(DBConnection.GetWards());
            buildings.AddRange(DBConnection.GetBuildings());
            
            ddWard.SelectedIndex = -1;
            ddBuilding.SelectedIndex = -1;
            ddWard.Items.Clear();
            ddBuilding.Items.Clear();
            ddWard.Items.AddRange(wards.ToArray());
            ddBuilding.Items.AddRange(buildings.ToArray());
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

         }

        private void ddWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            wm = wards.Find((ward) => ward == (WardModel)ddWard.SelectedItem);
            txtWardID.Text = wm.WardID.ToString();
            
            txtWardDescription.Text = wm.WardDescription;
            ddBuilding.SelectedItem = wm.Building;
            txtWardSpecialty.Text = wm.Specialty;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection.RemoveWard(wm);
            System.Windows.Forms.MessageBox.Show("Ward deleted successfully");
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bm = buildings.Find((building) => building == (BuildingModel)ddBuilding.SelectedItem);
            string wardDescription = txtWardDescription.Text, wardSpecialty = txtWardSpecialty.Text;
            DBConnection.UpdateWard(wardDescription, wardSpecialty, bm.BuildingID, wm.WardID);
            System.Windows.Forms.MessageBox.Show("Ward updated successfully");
            
        }
    }
}
