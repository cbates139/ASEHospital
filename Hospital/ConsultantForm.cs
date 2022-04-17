using Hospital.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class ConsultantForm : Form
    {
        readonly LoginMenu MainMenu;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColour = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedColour = Color.FromKnownColor(KnownColor.ControlDark);
        public ConsultantForm(LoginMenu menuInstance)
        {
            InitializeComponent();
            InitialiseNavigationControl();
            InitialiseNavigationButtons();
            MainMenu = menuInstance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void InitialiseNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() //User Control List
            { new ConsultantHome(), new ConsultantPatientView(),  new ConsultantServiceManage()};

            navigationControl = new NavigationControl(userControls, panel2); //Create instance of navigation control class
            navigationControl.Display(0); //display  UserControl as Default
        }
        private void InitialiseNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { logout_button, home_button, back_button, patients_button, serviceManagement_button };

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

        private void serviceManagement_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(serviceManagement_button);

        }

        private void patients_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(patients_button);
        }
    }
}
