namespace CPPTesting
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            b_backfadmin = new Button();
            b_adminLogin = new Button();
            txt_admin_pass = new TextBox();
            txt_admin_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // b_backfadmin
            // 
            b_backfadmin.BackColor = Color.FromArgb(17, 24, 39);
            b_backfadmin.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            b_backfadmin.ForeColor = Color.FromArgb(224, 224, 224);
            b_backfadmin.Location = new Point(656, 424);
            b_backfadmin.Name = "b_backfadmin";
            b_backfadmin.Size = new Size(112, 34);
            b_backfadmin.TabIndex = 13;
            b_backfadmin.Text = "back";
            b_backfadmin.UseVisualStyleBackColor = false;
            b_backfadmin.Click += b_backfadmin_Click;
            // 
            // b_adminLogin
            // 
            b_adminLogin.BackColor = Color.FromArgb(17, 24, 39);
            b_adminLogin.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            b_adminLogin.ForeColor = Color.FromArgb(224, 224, 224);
            b_adminLogin.Location = new Point(481, 424);
            b_adminLogin.Name = "b_adminLogin";
            b_adminLogin.Size = new Size(112, 34);
            b_adminLogin.TabIndex = 12;
            b_adminLogin.Text = "Login";
            b_adminLogin.UseVisualStyleBackColor = false;
            b_adminLogin.Click += b_adminLogin_Click;
            // 
            // txt_admin_pass
            // 
            txt_admin_pass.BackColor = Color.FromArgb(75, 85, 94);
            txt_admin_pass.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txt_admin_pass.ForeColor = Color.FromArgb(224, 224, 224);
            txt_admin_pass.Location = new Point(486, 346);
            txt_admin_pass.Name = "txt_admin_pass";
            txt_admin_pass.PasswordChar = '*';
            txt_admin_pass.Size = new Size(297, 33);
            txt_admin_pass.TabIndex = 11;
            // 
            // txt_admin_email
            // 
            txt_admin_email.BackColor = Color.FromArgb(75, 85, 94);
            txt_admin_email.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txt_admin_email.ForeColor = Color.FromArgb(224, 224, 224);
            txt_admin_email.Location = new Point(486, 278);
            txt_admin_email.Name = "txt_admin_email";
            txt_admin_email.Size = new Size(297, 33);
            txt_admin_email.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(363, 353);
            label3.Name = "label3";
            label3.Size = new Size(110, 26);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(384, 285);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(500, 211);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 7;
            label1.Text = "Admin Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 61);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 24, 39);
            label4.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(93, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 36);
            label4.TabIndex = 2;
            label4.Text = "VOTING PORTAL";
            label4.Click += label4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(b_backfadmin);
            Controls.Add(b_adminLogin);
            Controls.Add(txt_admin_pass);
            Controls.Add(txt_admin_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_backfadmin;
        private Button b_adminLogin;
        private TextBox txt_admin_pass;
        private TextBox txt_admin_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}