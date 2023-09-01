using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace CPPTesting
{
    public partial class Form1 : Form
    {
        String email, pass;
        String randomCode;
        public static String to;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 regform = new Form2();
            regform.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = txtLoginMail.Text;
            pass = txtLoginPass.Text;
            if (email != null && pass != null)
            {
                string query = "select count(*) from voters where email='" + email + "' and " +
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
                    txtLoginMail.ReadOnly = true;
                    txtLoginPass.ReadOnly = true;
                    String from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (email).ToString();
                    from = "mmpvotingportal@gmail.com";
                    pass = "bifhckwvoodbssux";
                    messageBody = "Your OTP is : " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "OTP for email verification";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Send Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("fill the blanks");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            if (randomCode == txtLoginOtp.Text)
            {
                //MessageBox.Show("success");
                string query = "select ID from voters where email='" + email + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                Globals.SetId((int)command.ExecuteScalar(), email);
                connection.Close();
                MessageBox.Show("final added");
                AllElectionsUserF allElectionsUserF = new AllElectionsUserF();
                this.Hide();
                allElectionsUserF.ShowDialog();

            }
            else
            {
                MessageBox.Show("wrong otp");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 adminlogin = new Form3();
            this.Hide();
            adminlogin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public static class Globals
    {
        public static int voterid { get; private set; }
        public static string e_mail { get; private set; }

        public static void SetId(int id, string mail)
        {
            voterid = id;
            e_mail = mail;
        }
    }
    public static class GlobalsForSQLCon
    {
        public static readonly SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");
    }
}