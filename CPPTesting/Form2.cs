using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPPTesting
{
    public partial class Form2 : Form
    {
        bool isCollmail, isValidMail, isSamePass;
        String firstName, lastName, password, email, rollno, enrollno, branch, year;
        String randomCode;
        public static String to;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Voting_Portal;Integrated Security=True");

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            String createPass = txtCrPass.Text;
            String confirmPass = txtConPass.Text;
            if (!createPass.Equals(confirmPass))
            {
                label_passMatch.Text = "pass does not match";
            }
            else
            {
                label_passMatch.Text = "pass matched";
                isSamePass = true;
            }
        }

        private void label_passMatch_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRoll_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOtp_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            String temail = txtEmail.Text;
            if (!temail.EndsWith("@mmpolytechnic.com"))
            {
                l_collmailverify.Text = "enter mail with @mmpolytechnic.com only";
                BVerify.Hide();
                isCollmail = false;
            }
            else
            {
                l_collmailverify.Text = "...";
                BVerify.Show();
                isCollmail = true;
            }
        }

        private void l_collmailverify_Click(object sender, EventArgs e)
        {
        }

        private void txtCrPass_TextChanged(object sender, EventArgs e)
        {
            String createPass = txtCrPass.Text;
            String confirmPass = txtConPass.Text;
            if (!createPass.Equals(confirmPass))
            {
                label_passMatch.Text = "pass does not match";
            }
            else
            {
                label_passMatch.Text = "pass matched";
                isSamePass = true;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtOtp.Text).ToString())
            {
                lOtpVerify.Text = "email verified";
                txtEmail.ReadOnly = true;
                isValidMail = true;
            }
            else
            {
                lOtpVerify.Text = "wrong OTP";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text)
                && !String.IsNullOrEmpty(txtLastName.Text)
                && isSamePass == true
                && isValidMail == true
                && !String.IsNullOrEmpty(txtRoll.Text)
                && !String.IsNullOrEmpty(txtEnroll.Text)
                && cbBranch.SelectedItem != null
                && cbYear.SelectedItem != null)
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                password = txtConPass.Text;
                email = txtEmail.Text;
                rollno = txtRoll.Text;
                enrollno = txtEnroll.Text;
                branch = cbBranch.Text.ToString();
                year = cbYear.Text.ToString();
                connection.Open();
                SqlCommand command = new SqlCommand("insert into voters (firstname, lastname, password, email, rollno, enrollmentno, branch, year) values(@f_name,@l_name," +
                    "@password,@email,@rollno,@enrollmentno,@branch,@year)", connection);
                command.Parameters.AddWithValue("@f_name", firstName);
                command.Parameters.AddWithValue("@l_name", lastName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@rollno", rollno);
                command.Parameters.AddWithValue("@enrollmentno", enrollno);
                command.Parameters.AddWithValue("@branch", branch);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Successfully Registered\nLogin again");


                string query = "INSERT INTO HasVoted (VoterID) SELECT ID FROM voters WHERE email = @Email";
                SqlCommand sqlcommand = new SqlCommand(query, connection);
                sqlcommand.Parameters.AddWithValue("@Email", email);
                connection.Open();
                sqlcommand.ExecuteNonQuery();

                MessageBox.Show("Added to HasVoted");
                this.Hide();
                Form1 Flogin = new Form1();
                Flogin.ShowDialog();

                connection.Close();

            }
            else
            {
                MessageBox.Show("Enter Valid Details");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void bSendOtp_Click(object sender, EventArgs e)
        {
            if (isCollmail == true)
            {
                int v = check(txtEmail.Text);
                if (v != 1)
                {
                    String from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txtEmail.Text).ToString();
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
                else
                {
                    MessageBox.Show("Email already registered");
                }

            }
        }
        int check(string email)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM voters WHERE email=@Email";
            SqlCommand command1 = new SqlCommand(query, connection);
            command1.Parameters.AddWithValue("@Email", email);
            int v = (int)command1.ExecuteScalar();
            connection.Close();
            return v;
        }


        private void b_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Flogin = new Form1();
            Flogin.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
