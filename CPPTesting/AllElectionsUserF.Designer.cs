namespace CPPTesting
{
    partial class AllElectionsUserF
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
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(813, 93);
            label1.Name = "label1";
            label1.Size = new Size(76, 26);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(285, 93);
            label2.Name = "label2";
            label2.Size = new Size(138, 26);
            label2.TabIndex = 1;
            label2.Text = "All Elections";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = SystemColors.Control;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(1075, 30);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(77, 26);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 70);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 24, 39);
            label4.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(54, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 36);
            label4.TabIndex = 4;
            label4.Text = "VOTING PORTAL";
            // 
            // AllElectionsUserF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AllElectionsUserF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllElectionsUserF";
            Load += AllElectionsUserF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Label label4;
    }
}