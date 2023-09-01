using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CPPTesting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");
        String email, pass;

        private void b_adminLogin_Click(object sender, EventArgs e)
        {
            email = txt_admin_email.Text;
            pass = txt_admin_pass.Text;
            if (email != null && pass != null)
            {
                string query = "select count(*) from admintable where email='" + email + "' and " +
                    "password='" + pass + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                connection.Close();
                if (v != 1)
                {
                    MessageBox.Show("Email Unregistered or incorrect password");
                }
                else
                {
                    MessageBox.Show("Success");
                    AllElectionsAdminF allElectionsAdminF = new AllElectionsAdminF();
                    this.Hide();
                    allElectionsAdminF.ShowDialog();

                }


            }
            else
            {
                MessageBox.Show("fill the blanks");
            }
        }

        private void b_backfadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Flogin = new Form1();
            Flogin.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
