namespace CPPTesting
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            l_collmailverify = new Label();
            label_passMatch = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            cbYear = new ComboBox();
            cbBranch = new ComboBox();
            txtEnroll = new TextBox();
            txtRoll = new TextBox();
            txtOtp = new TextBox();
            txtEmail = new TextBox();
            txtConPass = new TextBox();
            txtCrPass = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            BVerify = new Button();
            label1 = new Label();
            BSubmit = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            bSendOtp = new Button();
            lOtpVerify = new Label();
            b_back = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // l_collmailverify
            // 
            l_collmailverify.AutoSize = true;
            l_collmailverify.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            l_collmailverify.Location = new Point(832, 292);
            l_collmailverify.Margin = new Padding(4, 0, 4, 0);
            l_collmailverify.Name = "l_collmailverify";
            l_collmailverify.Size = new Size(27, 26);
            l_collmailverify.TabIndex = 58;
            l_collmailverify.Text = "...";
            l_collmailverify.Click += l_collmailverify_Click;
            // 
            // label_passMatch
            // 
            label_passMatch.AutoSize = true;
            label_passMatch.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_passMatch.Location = new Point(641, 242);
            label_passMatch.Margin = new Padding(4, 0, 4, 0);
            label_passMatch.Name = "label_passMatch";
            label_passMatch.Size = new Size(42, 26);
            label_passMatch.TabIndex = 57;
            label_passMatch.Text = "......";
            label_passMatch.Click += label_passMatch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(670, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 56;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(75, 85, 94);
            txtLastName.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(796, 151);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(310, 33);
            txtLastName.TabIndex = 55;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // cbYear
            // 
            cbYear.BackColor = Color.FromArgb(75, 85, 94);
            cbYear.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year" });
            cbYear.Location = new Point(251, 470);
            cbYear.Margin = new Padding(4, 3, 4, 3);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(381, 34);
            cbYear.TabIndex = 54;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // cbBranch
            // 
            cbBranch.BackColor = Color.FromArgb(75, 85, 94);
            cbBranch.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cbBranch.FormattingEnabled = true;
            cbBranch.Items.AddRange(new object[] { "Computer", "Mechanical", "Electrical", "Mechatronic", "Automobile" });
            cbBranch.Location = new Point(251, 422);
            cbBranch.Margin = new Padding(4, 3, 4, 3);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(380, 34);
            cbBranch.TabIndex = 53;
            cbBranch.SelectedIndexChanged += cbBranch_SelectedIndexChanged;
            // 
            // txtEnroll
            // 
            txtEnroll.BackColor = Color.FromArgb(75, 85, 94);
            txtEnroll.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnroll.Location = new Point(832, 372);
            txtEnroll.Margin = new Padding(4, 3, 4, 3);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(310, 33);
            txtEnroll.TabIndex = 52;
            txtEnroll.TextChanged += txtEnroll_TextChanged;
            // 
            // txtRoll
            // 
            txtRoll.BackColor = Color.FromArgb(75, 85, 94);
            txtRoll.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoll.Location = new Point(254, 376);
            txtRoll.Margin = new Padding(4, 3, 4, 3);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(380, 33);
            txtRoll.TabIndex = 51;
            txtRoll.TextChanged += txtRoll_TextChanged;
            // 
            // txtOtp
            // 
            txtOtp.BackColor = Color.FromArgb(75, 85, 94);
            txtOtp.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtOtp.Location = new Point(252, 333);
            txtOtp.Margin = new Padding(4, 3, 4, 3);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(380, 33);
            txtOtp.TabIndex = 50;
            txtOtp.TextChanged += txtOtp_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(75, 85, 94);
            txtEmail.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(252, 287);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 33);
            txtEmail.TabIndex = 49;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtConPass
            // 
            txtConPass.BackColor = Color.FromArgb(75, 85, 94);
            txtConPass.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtConPass.Location = new Point(252, 241);
            txtConPass.Margin = new Padding(4, 3, 4, 3);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(380, 33);
            txtConPass.TabIndex = 48;
            txtConPass.TextChanged += txtConPass_TextChanged;
            // 
            // txtCrPass
            // 
            txtCrPass.BackColor = Color.FromArgb(75, 85, 94);
            txtCrPass.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtCrPass.Location = new Point(254, 195);
            txtCrPass.Margin = new Padding(4, 3, 4, 3);
            txtCrPass.Name = "txtCrPass";
            txtCrPass.Size = new Size(378, 33);
            txtCrPass.TabIndex = 47;
            txtCrPass.TextChanged += txtCrPass_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(75, 85, 94);
            txtFirstName.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(252, 151);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(380, 33);
            txtFirstName.TabIndex = 46;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(37, 343);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 45;
            label2.Text = "Enter otp";
            label2.Click += label2_Click;
            // 
            // BVerify
            // 
            BVerify.BackColor = Color.FromArgb(17, 24, 39);
            BVerify.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BVerify.ForeColor = Color.FromArgb(224, 224, 224);
            BVerify.Location = new Point(654, 339);
            BVerify.Margin = new Padding(4, 3, 4, 3);
            BVerify.Name = "BVerify";
            BVerify.Size = new Size(109, 35);
            BVerify.TabIndex = 44;
            BVerify.Text = "verify";
            BVerify.UseVisualStyleBackColor = false;
            BVerify.Click += BVerify_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(37, 248);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 26);
            label1.TabIndex = 43;
            label1.Text = "Confirm Password";
            label1.Click += label1_Click;
            // 
            // BSubmit
            // 
            BSubmit.BackColor = Color.FromArgb(17, 24, 39);
            BSubmit.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BSubmit.ForeColor = Color.FromArgb(224, 224, 224);
            BSubmit.Location = new Point(251, 511);
            BSubmit.Margin = new Padding(4, 3, 4, 3);
            BSubmit.Name = "BSubmit";
            BSubmit.Size = new Size(146, 35);
            BSubmit.TabIndex = 42;
            BSubmit.Text = "Submit";
            BSubmit.UseVisualStyleBackColor = false;
            BSubmit.Click += BSubmit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Snow;
            label11.Location = new Point(37, 202);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(182, 26);
            label11.TabIndex = 41;
            label11.Text = "Create Password";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(37, 298);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(158, 26);
            label10.TabIndex = 40;
            label10.Text = "College E-mail";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(37, 478);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 26);
            label9.TabIndex = 39;
            label9.Text = "Year";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(37, 430);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 26);
            label8.TabIndex = 38;
            label8.Text = "Branch";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(642, 379);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(164, 26);
            label7.TabIndex = 37;
            label7.Text = "Enrollment no.";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(37, 383);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 26);
            label6.TabIndex = 36;
            label6.Text = "Roll No.";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(37, 158);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 26);
            label5.TabIndex = 35;
            label5.Text = "First Name";
            label5.Click += label5_Click;
            // 
            // bSendOtp
            // 
            bSendOtp.BackColor = Color.FromArgb(17, 24, 39);
            bSendOtp.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bSendOtp.ForeColor = Color.Snow;
            bSendOtp.Location = new Point(642, 289);
            bSendOtp.Margin = new Padding(4, 3, 4, 3);
            bSendOtp.Name = "bSendOtp";
            bSendOtp.Size = new Size(146, 35);
            bSendOtp.TabIndex = 59;
            bSendOtp.Text = "Send Otp";
            bSendOtp.UseVisualStyleBackColor = false;
            bSendOtp.Click += bSendOtp_Click;
            // 
            // lOtpVerify
            // 
            lOtpVerify.AutoSize = true;
            lOtpVerify.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lOtpVerify.Location = new Point(832, 339);
            lOtpVerify.Margin = new Padding(4, 0, 4, 0);
            lOtpVerify.Name = "lOtpVerify";
            lOtpVerify.Size = new Size(27, 26);
            lOtpVerify.TabIndex = 60;
            lOtpVerify.Text = "...";
            // 
            // b_back
            // 
            b_back.BackColor = Color.FromArgb(17, 24, 39);
            b_back.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            b_back.ForeColor = Color.Snow;
            b_back.Location = new Point(485, 511);
            b_back.Margin = new Padding(4, 3, 4, 3);
            b_back.Name = "b_back";
            b_back.Size = new Size(146, 35);
            b_back.TabIndex = 61;
            b_back.Text = "Back";
            b_back.UseVisualStyleBackColor = false;
            b_back.Click += b_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 67);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1722, 61);
            panel1.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 24, 39);
            label4.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(44, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 36);
            label4.TabIndex = 5;
            label4.Text = "VOTING PORTAL";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(b_back);
            Controls.Add(lOtpVerify);
            Controls.Add(bSendOtp);
            Controls.Add(l_collmailverify);
            Controls.Add(label_passMatch);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(cbYear);
            Controls.Add(cbBranch);
            Controls.Add(txtEnroll);
            Controls.Add(txtRoll);
            Controls.Add(txtOtp);
            Controls.Add(txtEmail);
            Controls.Add(txtConPass);
            Controls.Add(txtCrPass);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(BVerify);
            Controls.Add(label1);
            Controls.Add(BSubmit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            DoubleBuffered = true;
            Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_collmailverify;
        private Label label_passMatch;
        private Label label3;
        private TextBox txtLastName;
        private ComboBox cbYear;
        private ComboBox cbBranch;
        private TextBox txtEnroll;
        private TextBox txtRoll;
        private TextBox txtOtp;
        private TextBox txtEmail;
        private TextBox txtConPass;
        private TextBox txtCrPass;
        private TextBox txtFirstName;
        private Label label2;
        private Button BVerify;
        private Label label1;
        private Button BSubmit;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button bSendOtp;
        private Label lOtpVerify;
        private Button b_back;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
    }
}