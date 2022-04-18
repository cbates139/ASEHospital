using Hospital.User_Controls;
using Hospital.User_Controls.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AdminForm : Form
    {
        readonly LoginMenu MainMenu;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColour = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedColour = Color.FromKnownColor(KnownColor.ControlDark);
        public AdminForm(LoginMenu menuInstance)
        {
            InitializeComponent();
            InitialiseNavigationControl();
            InitialiseNavigationButtons();
            MainMenu = menuInstance;
        }

        private void InitialiseNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() //User Control List
            { new AdminHome(), new AdminPatientManagement(),  new AdminStaffManagement(), new AdminWardManagement()};

            navigationControl = new NavigationControl(userControls, panel2); //Create instance of navigation control class
            navigationControl.Display(0); //display  UserControl as Default
        }
        private void InitialiseNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { logout_button, home_button, back_button, patientManagement_button, staffManagement_button, wardManagement_button };

            navigationButtons = new NavigationButtons(buttons, btnDefaultColour, btnSelectedColour);
            navigationButtons.Highlight(home_button);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu.Show();
            Close();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(home_button);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //TO-DO:
            //navigationControl.Display(1);
        }

        private void patients_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(patientManagement_button);
        }

        private void staffManagement_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(staffManagement_button);
        }

        private void wardManagement_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(wardManagement_button);
        }
    }
}
