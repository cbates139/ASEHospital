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
    public partial class WardCreate : UserControl
    {
        public WardCreate()
        {
            InitializeComponent();
        }
        private BuildingModel bm = null;
        private readonly List<BuildingModel> buildings = new List<BuildingModel>();
        private void WardCreate_Load(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void RefreshData()
        {
            
            buildings.Clear();
            bm = null;
            
            buildings.AddRange(DBConnection.GetBuildings());

            txtWardDescription.Clear();
            txtWardSpecialty.Clear();
            ddBuilding.SelectedIndex = -1;
            ddBuilding.Items.Clear();
            ddBuilding.Items.AddRange(buildings.ToArray());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bm = buildings.Find((building) => building == (BuildingModel)ddBuilding.SelectedItem);
            System.Diagnostics.Debug.WriteLine(bm.BuildingID);
            string test = bm.BuildingID.ToString();

            DBConnection.AddWard(txtWardDescription.Text, txtWardSpecialty.Text, bm.BuildingID);
            
            RefreshData();

        }
    }
}
