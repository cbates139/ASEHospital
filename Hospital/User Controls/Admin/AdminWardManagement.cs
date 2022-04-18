using Hospital.User_Controls.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.User_Controls
{
    public partial class AdminWardManagement : UserControl
    {
        NavigationControl navigationControl;
        public AdminWardManagement()
        {
            InitializeComponent();
            List<UserControl> pages = new List<UserControl>() //Pages
            { new WardManagement(), new WardCreate() };

            navigationControl = new NavigationControl(pages, panel1); //Create instance of navigation control class
        }

        private void editWard_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0); //Display WardManagement
            

        }

        private void createWard_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1); //Display WardManagement
        }

        

    }
}
