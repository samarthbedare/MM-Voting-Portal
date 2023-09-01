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

namespace CPPTesting
{
    public partial class ViewPastAndOngoingEleAdminF : Form
    {
        public ViewPastAndOngoingEleAdminF()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            AllElectionsAdminF allElectionsAdminF = new AllElectionsAdminF();
            this.Hide();
            allElectionsAdminF.ShowDialog();
        }

        private void ViewPastAndOngoingEleAdminF_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Elections ORDER BY ID DESC", connection);

            // Create a data adapter and fill a data table with the results of the command
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Bind the data table to the DataGridView control
            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
