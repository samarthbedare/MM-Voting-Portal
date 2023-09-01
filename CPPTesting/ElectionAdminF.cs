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
    public partial class ElectionAdminF : Form
    {
        public ElectionAdminF()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void ElectionAdminF_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Candidates where electionID=@f_eid", connection);
            cmd.Parameters.AddWithValue("@f_eid", GlobalsForElectionSelected.electionid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCandidateF addCandidateF = new AddCandidateF();
            addCandidateF.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllElectionsAdminF allElectionsAdminF = new AllElectionsAdminF();
            allElectionsAdminF.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminVotesF adminVotesF = new AdminVotesF();
            adminVotesF.ShowDialog();
        }
    }
}
