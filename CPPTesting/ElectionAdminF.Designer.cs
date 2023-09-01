namespace CPPTesting
{
    partial class ElectionAdminF
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
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 92);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(699, 335);
            dataGridView1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ImageAlign = ContentAlignment.MiddleRight;
            linkLabel1.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel1.Location = new Point(850, 128);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(155, 26);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "add candidate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(1043, 9);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(130, 55);
            button1.TabIndex = 2;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ImageAlign = ContentAlignment.MiddleRight;
            linkLabel2.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel2.Location = new Point(850, 196);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(123, 26);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View Votes";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 70);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(17, 24, 39);
            label4.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(82, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 36);
            label4.TabIndex = 3;
            label4.Text = "VOTING PORTAL";
            // 
            // ElectionAdminF
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 65, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 588);
            Controls.Add(panel1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ElectionAdminF";
            Text = "ElectionAdminF";
            Load += ElectionAdminF_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private Button button1;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private Label label4;
    }
}