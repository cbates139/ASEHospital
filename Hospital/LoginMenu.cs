using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Send details to server to validate.
            switch(textBoxStaffId.Text)
            {
                case "Consultant": ConsultantLogin(); break;
                case "Admin": AdminLogin();  break;
                case "Junior": JuniorLogin(); break;
                case null: return;
            }
        }
        private void ConsultantLogin()
        {
            ConsultantForm Consultant = new ConsultantForm(this);
            Consultant.Show();
            Hide();
        }
        private void AdminLogin()
        {
            AdminForm Admin = new AdminForm(this);
            Admin.Show();
            Hide();
        }
        private void JuniorLogin()
        {
            Hide();
            JuniorForm Junior = new JuniorForm(this);
            Junior.Show();
        }
    }
}
