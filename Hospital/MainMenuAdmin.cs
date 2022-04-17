using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MainMenuAdmin : Form
    {
        readonly LoginMenu m;
        public MainMenuAdmin(LoginMenu menuInstance)
        {
            InitializeComponent();
            m = menuInstance;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Delete Session data.

            //Show login menu.
            m.Show();

            //Close this menu.
            Close();
        }

        private void btnWardManagement_Click(object sender, EventArgs e)
        {
            WardManagement wm = new WardManagement(this);

            wm.Show();

            Close();

        }

        private void MainMenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
