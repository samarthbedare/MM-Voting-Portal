using System;
using System.Collections;
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
    public partial class AllElectionsUserF : Form
    {
        public AllElectionsUserF()
        {
            InitializeComponent();
        }
        int id;
        List<LinkLabel> runtimeLinkLabels = new List<LinkLabel>();
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void AllElectionsUserF_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello Voter " + Globals.e_mail;
            id = Globals.voterid;

            AddLinkLabelsFromSqlTable();
        }
        private void AddLinkLabelsFromSqlTable()
        {
            Image image = Image.FromFile(@"C:\Users\Samarth Bedare\OneDrive\Pictures\New folder\Screenshot 2023-04-10 110236.png");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Elections WHERE end_time IS NULL", connection);
            SqlDataReader reader = command.ExecuteReader();
            int y = 150;
            while (reader.Read())
            {
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Text = reader["name"].ToString();
                linkLabel.Location = new Point(100, y); // Set the location of the LinkLabel
                //linkLabel.AutoSize = false;
                linkLabel.Width = 300;
                linkLabel.LinkColor = Color.FromArgb(129, 140, 248);
                linkLabel.Font = new Font("Cambria", 11, FontStyle.Bold);
                //linkLabel.BackgroundImage = image;
                //linkLabel.BackgroundImageLayout = ImageLayout.Stretch;
                linkLabel.Tag = reader["ID"].ToString(); // Store the ID of the row in the Tag property for later use
                linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked); // Add an event handler for the LinkClicked event
                this.Controls.Add(linkLabel); // Add the LinkLabel control to the form
                runtimeLinkLabels.Add(linkLabel); // Add the LinkLabel control to the List
                y += 30; // Increment the Y-coordinate of the location for the next LinkLabel
            }

            // Close the SQL database connection
            reader.Close();
            connection.Close();
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string rowID = linkLabel.Tag.ToString();
            GlobalsForElectionSelected.SetId(int.Parse(rowID));

            string rowidstr = rowID.ToString();
            string eleno = "ELection" + rowidstr;
            string connectionString = "Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT " + eleno + " FROM HasVoted WHERE VoterID=@VoterID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@VoterID", Globals.voterid);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    Election1UserF election1UserF = new Election1UserF();
                    this.Hide();
                    election1UserF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Already Voted");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string electionnameAno = "Election" + GlobalsForElectionSelected.electionid;
            string query = $"SELECT {electionnameAno} FROM HasVoted WHERE VoterID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Globals.voterid);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            if (result == null || result == DBNull.Value)
            {
                Election1UserF election1UserF = new Election1UserF();
                this.Hide();
                election1UserF.ShowDialog();
            }
            else { MessageBox.Show("Already Voted"); }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide(); form1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
