using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital.User_Controls.Admin
{
    public partial class AdminPatientManagement : UserControl
    {
        public AdminPatientManagement()
        {
            InitializeComponent();
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            RegisterPation RP = new RegisterPation();
            RP.ShowDialog();
        }
    }
}
