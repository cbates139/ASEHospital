using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class WardManagement : Form
    {
        readonly MainMenuAdmin m;
        public WardManagement(MainMenuAdmin menuInstance)
        {
            InitializeComponent();
            
           m = menuInstance;
            
        }

        private void WardManagement_Load(object sender, EventArgs e)
        {
            /*using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT [Task_temp_name], [Task_templatesID] FROM [Task_templates]";
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
