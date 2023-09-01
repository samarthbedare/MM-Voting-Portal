using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CPPTesting
{
    public partial class AllElectionsAdminF : Form
    {
        public AllElectionsAdminF()
        {
            InitializeComponent();
        }
        List<LinkLabel> runtimeLinkLabels = new List<LinkLabel>();
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewElectionAdminF addNewElectionAdminF = new AddNewElectionAdminF();
            addNewElectionAdminF.ShowDialog();
            this.Hide();
        }

        private void AllElectionsAdminF_Load(object sender, EventArgs e)
        {

            AddLinkLabelsFromSqlTable();

        }
        private void AddLinkLabelsFromSqlTable()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Elections WHERE end_time IS NULL", connection);
            SqlDataReader reader = command.ExecuteReader();
            int y = 160;
            while (reader.Read())
            {
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Text = reader["name"].ToString();
                linkLabel.Location = new Point(100, y); // Set the location of the LinkLabel
                linkLabel.LinkColor = Color.FromArgb(129, 140, 248);
                linkLabel.AutoSize=true;
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
            ElectionAdminF electionAdminF = new ElectionAdminF();
            this.Hide();
            electionAdminF.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (LinkLabel linkLabel in runtimeLinkLabels)
            {
                this.Controls.Remove(linkLabel);
            }
            runtimeLinkLabels.Clear(); // Clear the List
            AddLinkLabelsFromSqlTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewPastAndOngoingEleAdminF viewPastAndOngoingEleAdminF = new ViewPastAndOngoingEleAdminF();
            this.Hide();
            viewPastAndOngoingEleAdminF.ShowDialog();
        }
    }
    public static class GlobalsForElectionSelected
    {
        public static int electionid { get; private set; }

        public static void SetId(int id)
        {
            electionid = id;
        }
    }
}

