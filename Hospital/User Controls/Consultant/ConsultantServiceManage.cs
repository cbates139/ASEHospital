using Hospital.User_Controls.Consultant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.User_Controls
{
    public partial class ConsultantServiceManage : UserControl
    {
        NavigationControl navigationControl;
        public ConsultantServiceManage()
        {
            InitializeComponent();
            List<UserControl> pages = new List<UserControl>() //Pages
            { new ServiceManagement() };

            navigationControl = new NavigationControl(pages, panel1); //Create instance of navigation control class
        }

        private void editService_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0); //Display ServiceManagement

        }
    }
}
