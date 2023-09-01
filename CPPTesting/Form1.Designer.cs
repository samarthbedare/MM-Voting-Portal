namespace CPPTesting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button1 = new Button();
            txtLoginPass = new TextBox();
            label2 = new Label();
            txtLoginMail = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtLoginOtp = new TextBox();
            B_login = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(17, 24, 39);
            button2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(644, 497);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(146, 47);
            button2.TabIndex = 13;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 24, 39);
            button1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(459, 349);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(253, 35);
            button1.TabIndex = 11;
            button1.Text = "Submit and send otp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtLoginPass
            // 
            txtLoginPass.BackColor = Color.FromArgb(75, 85, 94);
            txtLoginPass.Location = new Point(458, 292);
            txtLoginPass.Margin = new Padding(4, 3, 4, 3);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PasswordChar = '*';
            txtLoginPass.Size = new Size(446, 33);
            txtLoginPass.TabIndex = 10;
            txtLoginPass.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(251, 292);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 26);
            label2.TabIndex = 9;
            label2.Text = "Enter Password";
            label2.Click += label2_Click;
            // 
            // txtLoginMail
            // 
            txtLoginMail.BackColor = Color.FromArgb(75, 85, 94);
            txtLoginMail.Location = new Point(459, 218);
            txtLoginMail.Margin = new Padding(4, 3, 4, 3);
            txtLoginMail.Name = "txtLoginMail";
            txtLoginMail.Size = new Size(446, 33);
            txtLoginMail.TabIndex = 8;
            txtLoginMail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(290, 225);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 26);
            label1.TabIndex = 7;
            label1.Text = "Enter Email";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(290, 414);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 26);
            label4.TabIndex = 14;
            label4.Text = "Enter OTP";
            label4.Click += label4_Click;
            // 
            // txtLoginOtp
            // 
            txtLoginOtp.BackColor = Color.FromArgb(75, 85, 94);
            txtLoginOtp.Location = new Point(458, 414);
            txtLoginOtp.Margin = new Padding(4, 3, 4, 3);
            txtLoginOtp.Name = "txtLoginOtp";
            txtLoginOtp.Size = new Size(447, 33);
            txtLoginOtp.TabIndex = 15;
            // 
            // B_login
            // 
            B_login.BackColor = Color.FromArgb(17, 24, 39);
            B_login.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            B_login.ForeColor = Color.FromArgb(224, 224, 224);
            B_login.Location = new Point(408, 497);
            B_login.Margin = new Padding(4, 3, 4, 3);
            B_login.Name = "B_login";
            B_login.Size = new Size(146, 47);
            B_login.TabIndex = 16;
            B_login.Text = "Login";
            B_login.UseVisualStyleBackColor = false;
            B_login.Click += B_login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ImageAlign = ContentAlignment.MiddleRight;
            linkLabel1.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel1.Location = new Point(1021, 17);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(140, 26);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(541, 90);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 68);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(17, 24, 39);
            label3.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(79, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 36);
            label3.TabIndex = 19;
            label3.Text = "VOTING PORTAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(B_login);
            Controls.Add(txtLoginOtp);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLoginPass);
            Controls.Add(label2);
            Controls.Add(txtLoginMail);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Padding = new Padding(4, 3, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtLoginPass;
        private Label label2;
        private TextBox txtLoginMail;
        private Label label1;
        private Label label4;
        private TextBox txtLoginOtp;
        private Button B_login;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
    }
}