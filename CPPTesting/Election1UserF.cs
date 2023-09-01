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
    public partial class Election1UserF : Form
    {
        public Election1UserF()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void Election1UserF_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True"))
            {
                // Open the database connection
                connection.Open();

                // Define the SQL query to retrieve candidate data
                string query = "SELECT ID, name, partyname, imagepath FROM Candidates WHERE electionID='" + GlobalsForElectionSelected.electionid + "'";

                // Create a new SqlCommand object with the SQL query and the SqlConnection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a new DataTable object to hold the results
                    DataTable candidatesTable = new DataTable();

                    // Use a SqlDataAdapter object to fill the DataTable with the results of the SQL query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(candidatesTable);
                    }
                    int groupBoxX = 30;
                    int groupBoxY = 120;
                    int groupBoxWidth = 300;
                    int groupBoxHeight = 150;

                    // Add a GroupBox for each candidate
                    foreach (DataRow row in candidatesTable.Rows)
                    {
                        // Create a new GroupBox control
                        GroupBox groupBox = new GroupBox();
                        groupBox.Location = new Point(groupBoxX, groupBoxY);
                        groupBox.Size = new Size(groupBoxWidth, groupBoxHeight);
                        groupBox.BackColor = Color.FromArgb(38, 45, 57);

                        // Create labels for each candidate data
                        Label idLabel = new Label();
                        idLabel.Text = "ID: " + row["ID"].ToString();
                        idLabel.Location = new Point(10, 20);
                        idLabel.Font = new Font("Cambria", 11, FontStyle.Bold);
                        idLabel.ForeColor = Color.FromArgb(129, 140, 248);
                        idLabel.AutoSize = true;
                        groupBox.Controls.Add(idLabel);

                        Label nameLabel = new Label();
                        nameLabel.Text = "Name: " + row["name"].ToString();
                        nameLabel.Location = new Point(10, 40);
                        nameLabel.ForeColor = Color.FromArgb(129, 140, 248);
                        nameLabel.Font = new Font("Cambria", 11, FontStyle.Bold);
                        nameLabel.AutoSize = true;
                        groupBox.Controls.Add(nameLabel);

                        Label partyLabel = new Label();
                        partyLabel.Text = "Party: " + row["PartyName"].ToString();
                        partyLabel.Location = new Point(10, 60);
                        partyLabel.ForeColor = Color.FromArgb(129, 140, 248);
                        partyLabel.Font = new Font("Cambria", 11, FontStyle.Bold);
                        partyLabel.AutoSize = true;
                        groupBox.Controls.Add(partyLabel);

                        PictureBox pictureBox = new PictureBox();
                        string imagePath = row["imagepath"].ToString();
                        pictureBox.Image = Image.FromFile(imagePath);
                        pictureBox.Location = new Point(180, 10);
                        pictureBox.Size = new Size(100, 100);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        groupBox.Controls.Add(pictureBox);

                        Button voteButton = new Button();
                        voteButton.Text = "Vote";
                        voteButton.Tag = row["ID"].ToString(); // store candidate ID in button tag for later use
                        voteButton.Location = new Point(10, 90);
                        voteButton.Size = new Size(100, 45);
                        voteButton.Font = new Font("Cambria", 11, FontStyle.Bold);
                        voteButton.ForeColor = Color.FromArgb(224, 224, 224);
                        voteButton.BackColor = Color.FromArgb(17, 24, 39);
                        voteButton.Click += new EventHandler(voteButton_Click);
                        groupBox.Controls.Add(voteButton);

                        // Add the GroupBox to the form
                        this.Controls.Add(groupBox);

                        // Move the location of the next GroupBox down
                        groupBoxY += groupBoxHeight + 10;
                    }
                }

            }
        }
        private void voteButton_Click(object sender, EventArgs e)
        {
            Button voteButton = sender as Button;
            string candidateID = voteButton.Tag.ToString();
            int cadID = int.Parse(candidateID);
            DialogResult dialogResult = MessageBox.Show("You have selected " + candidateID + "\nAre you sure?", "Vote Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Votes (CandidateID,ElectionID) VALUES(@f_cadID,@f_eleID)", con);
                sqlCommand.Parameters.AddWithValue("@f_cadID", cadID);
                sqlCommand.Parameters.AddWithValue("@f_eleID", GlobalsForElectionSelected.electionid);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    string eid = GlobalsForElectionSelected.electionid.ToString();
                    string electionnameAno = "Election" + eid;
                    SqlCommand sqlCommand1 = new SqlCommand($"UPDATE HasVoted SET {electionnameAno} = @true WHERE VoterID = @uid", con);
                    sqlCommand1.Parameters.AddWithValue("@true", true);
                    sqlCommand1.Parameters.AddWithValue("@uid", Globals.voterid);
                    sqlCommand1.ExecuteNonQuery();
                    MessageBox.Show("Voted successfully");
                    this.Hide();
                    AllElectionsUserF allElectionsUserF = new AllElectionsUserF();
                    allElectionsUserF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("vote not added");
                }
                con.Close();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            AllElectionsUserF allElectionsUserF = new AllElectionsUserF();
            allElectionsUserF.ShowDialog();
            this.Hide();
        }
    }
}
