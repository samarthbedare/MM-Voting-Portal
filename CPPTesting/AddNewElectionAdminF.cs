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
    public partial class AddNewElectionAdminF : Form
    {
        public AddNewElectionAdminF()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string ele_name = textBox1.Text;
            int eleid;
            SqlCommand sqlCommand = new SqlCommand("insert into Elections (name,start_time) values (@f_name,@f_datetime)", connection);
            sqlCommand.Parameters.AddWithValue("@f_name", ele_name);
            SqlParameter parameter = new SqlParameter("@f_datetime", System.Data.SqlDbType.DateTime);
            parameter.Value = DateTime.Now;

            sqlCommand.Parameters.Add(parameter);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            SqlCommand command = new SqlCommand("SELECT ID FROM Elections WHERE name = @elename", connection);
            command.Parameters.AddWithValue("@elename", ele_name);
            connection.Open();    // Open the database connection
            eleid = (int)command.ExecuteScalar();   // Execute the query and store the result in the variable
            connection.Close();
            string eleidstr = eleid.ToString();
            string eletoaddtocolumn = "Election" + eleidstr;


            SqlCommand command1 = new SqlCommand($"ALTER TABLE HasVoted ADD {eletoaddtocolumn} BIT", connection);
            command1.Parameters.AddWithValue("@columnName", eletoaddtocolumn);
            connection.Open();
            command1.ExecuteNonQuery();
            connection.Close();

            this.Hide();
            AllElectionsAdminF allElectionsAdminF = new AllElectionsAdminF();
            allElectionsAdminF.ShowDialog();
        }

        private void AddNewElectionAdminF_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
