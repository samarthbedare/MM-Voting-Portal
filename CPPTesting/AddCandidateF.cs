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
    public partial class AddCandidateF : Form
    {
        public AddCandidateF()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");
        String name, partyname, imagePath, filePath;

        private void button1_Click(object sender, EventArgs e)
        {

            //int eid = int.Parse(textBox3.Text);
            int eid = 1;
            name = textBox1.Text;
            partyname = textBox2.Text;

            connection.Open();
            string query = "INSERT INTO Candidates (name, partyname, electionID, imagepath) VALUES (@value1, @value2, @value3, @value4)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", name);
            command.Parameters.AddWithValue("@value2", partyname);
            command.Parameters.AddWithValue("@value3", GlobalsForElectionSelected.electionid);
            command.Parameters.AddWithValue("@value4", filePath);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");
            this.Hide();
            ElectionAdminF electionAdminF = new ElectionAdminF();
            electionAdminF.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imagePath = openFileDialog1.FileName;
            textBox3.Text = imagePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                // Do something with the file path variable
            }

        }

        private void AddCandidateF_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElectionAdminF electionAdminF = new ElectionAdminF();
            electionAdminF.ShowDialog();
        }
    }
}
