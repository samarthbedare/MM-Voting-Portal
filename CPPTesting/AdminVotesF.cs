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
    public partial class AdminVotesF : Form
    {
        public AdminVotesF()
        {
            InitializeComponent();
        }

        private void AdminVotesF_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True";
            string sqlQuery = "SELECT TOP 5 t.CandidateID, c.name, COUNT(*) as voteCount FROM Votes t INNER JOIN Candidates c ON t.CandidateID = c.ID WHERE t.electionID = @electionID GROUP BY t.CandidateID, c.name ORDER BY voteCount DESC";

            dataGridView1.Columns.Add("CandidateID", "Candidate ID");
            dataGridView1.Columns.Add("name", "Candidate Name");
            dataGridView1.Columns.Add("voteCount", "Vote Count");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@electionID", GlobalsForElectionSelected.electionid);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int candidateID = reader.GetInt32(0);
                    string candidateName = reader.GetString(1);
                    int voteCount = reader.GetInt32(2);

                    // Set the values in the DataGridView
                    dataGridView1.Rows.Add(candidateID, candidateName, voteCount);
                }

                reader.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElectionAdminF electionAdminF = new ElectionAdminF();
            electionAdminF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Vote Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                string connectionString = "Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True";
                string sqlQuery = "SELECT TOP 3 t.CandidateID, c.Name, COUNT(*) as voteCount FROM Votes t INNER JOIN Candidates c ON t.CandidateID = c.ID WHERE t.ElectionID = @electionID GROUP BY t.CandidateID, c.Name ORDER BY voteCount DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@electionID", GlobalsForElectionSelected.electionid);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    List<string> candidateDetails = new List<string>();

                    while (reader.Read())
                    {
                        int candidateID = reader.GetInt32(0);
                        string candidateName = reader.GetString(1);
                        int voteCount = reader.GetInt32(2);

                        string candidateInfo = "ID: " + candidateID + ", Name: " + candidateName + ", Votes: " + voteCount;

                        candidateDetails.Add(candidateInfo);
                    }
                    connection.Close();

                    reader.Close();

                    if (candidateDetails.Count > 0)
                    {
                        string message = "The top 3 candidates are: \n\n" + string.Join("\n", candidateDetails);
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("There are no candidates with votes in the specified election.");
                    }


                    SqlCommand command1 = new SqlCommand("SELECT TOP 1 t.CandidateID, c.Name, COUNT(*) as voteCount1 FROM Votes t INNER JOIN Candidates c ON t.CandidateID = c.ID WHERE t.ElectionID = @electionID GROUP BY t.CandidateID, c.Name ORDER BY voteCount1 DESC", connection);
                    command1.Parameters.AddWithValue("@electionID", GlobalsForElectionSelected.electionid);

                    connection.Open();
                    SqlDataReader reader1 = command.ExecuteReader();
                    int CID = 0;
                    string CName = "";
                    int voteCount1 = 0;

                    if (reader1.Read())
                    {
                        CID = reader1.GetInt32(0);
                        CName = reader1.GetString(1);
                        voteCount1 = reader1.GetInt32(2);
                    }

                    reader1.Close();
                    connection.Close();
                    string cidstr = CID.ToString();
                    string results = cidstr + " " + CName;
                    if (CID != 0)
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE Elections SET end_time = @value1, results = @value2 WHERE ID = @eid", connection);
                        command2.Parameters.AddWithValue("@eid", GlobalsForElectionSelected.electionid);
                        command2.Parameters.AddWithValue("@value1", DateTime.Now);
                        command2.Parameters.AddWithValue("@value2", results);
                        connection.Open();
                        command2.ExecuteNonQuery();
                        connection.Close();
                        this.Hide();
                        AllElectionsAdminF allElectionsAdminF = new AllElectionsAdminF();
                        allElectionsAdminF.ShowDialog();


                    }
                    else
                    {
                        // Handle the case where no candidate was found
                    }
                }
            }

        }
    }
}
