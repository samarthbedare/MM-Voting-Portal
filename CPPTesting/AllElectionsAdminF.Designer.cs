namespace CPPTesting
{
    partial class AllElectionsAdminF
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            linkLabel1.ImageAlign = ContentAlignment.TopRight;
            linkLabel1.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel1.Location = new Point(918, 141);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(140, 26);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Add Election";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 24, 39);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(992, 484);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 1;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(1005, 20);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(146, 42);
            button2.TabIndex = 2;
            button2.Text = "logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ImageAlign = ContentAlignment.MiddleRight;
            linkLabel2.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel2.Location = new Point(904, 231);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(190, 52);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View past and \r\nongoing elections";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 78);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(406, 99);
            label1.Name = "label1";
            label1.Size = new Size(291, 33);
            label1.TabIndex = 5;
            label1.Text = "All Running Elections";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 24, 39);
            label4.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(61, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 36);
            label4.TabIndex = 4;
            label4.Text = "VOTING PORTAL";
            // 
            // AllElectionsAdminF
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            DoubleBuffered = true;
            Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AllElectionsAdminF";
            Text = "AllElectionsAdminF";
            Load += AllElectionsAdminF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private Label label1;
        private Label label4;
    }
}