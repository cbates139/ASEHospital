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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultantForm Consultant = new ConsultantForm();
            Consultant.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            JuniorForm Junior = new JuniorForm();
            Junior.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm Admin = new AdminForm();
            Admin.Show();
            Hide();
        }
    }
}
