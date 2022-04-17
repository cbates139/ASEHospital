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
    public partial class JuniorForm : Form
    {
        readonly LoginMenu MainMenu;
        
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColour = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedColour = Color.FromKnownColor(KnownColor.ControlDark);

        public JuniorForm(LoginMenu menuInstance)
        {
            InitializeComponent();
            InitialiseNavigationControl();
            InitialiseNavigationButtons();
            MainMenu = menuInstance;                        
        }
        private void InitialiseNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() //User Control List
            { new JuniorHome(), new JuniorPatientView(),  new JuniorViewService()};

            navigationControl = new NavigationControl(userControls, panel2); //Create instance of navigation control class
            navigationControl.Display(0); //display  UserControl as Default
        }
        private void InitialiseNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { logout_button, home_button, back_button, patients_button, viewService_button };

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
            navigationButtons.Highlight(patients_button);
        }

        private void viewService_button_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(viewService_button);
        }
    }
}
