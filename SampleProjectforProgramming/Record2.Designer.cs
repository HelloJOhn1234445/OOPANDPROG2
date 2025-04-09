namespace SampleProjectforProgramming
{
    partial class Record2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grecords = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gtimeinout = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gaddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.button5 = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(946, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // cboSearch
            // 
            this.cboSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "ID",
            "Student_ID",
            "Student_Name",
            "Program",
            "Date",
            "Time"});
            this.cboSearch.Location = new System.Drawing.Point(372, 42);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(197, 32);
            this.cboSearch.TabIndex = 35;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search By:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(586, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(336, 30);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.button1);
            this.guna2Panel2.Controls.Add(this.button2);
            this.guna2Panel2.Controls.Add(this.button3);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Green;
            this.guna2Panel2.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1160, 72);
            this.guna2Panel2.TabIndex = 39;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1122, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.label11.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(509, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 46);
            this.label11.TabIndex = 38;
            this.label11.Text = "AttendScan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Records";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Time In/Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::SampleProjectforProgramming.Properties.Resources._440979595_1825340057973007_1015642796755802723_n_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(400, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Bisque;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.cboSearch);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.txtSearch);
            this.guna2ShadowPanel1.Controls.Add(this.dataGridView1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Bisque;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(193, 72);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(966, 534);
            this.guna2ShadowPanel1.TabIndex = 40;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student Records";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "Admin";
            // 
            // grecords
            // 
            this.grecords.AutoRoundedCorners = true;
            this.grecords.BackColor = System.Drawing.Color.Transparent;
            this.grecords.BorderRadius = 16;
            this.grecords.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.grecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.grecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.grecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.grecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.grecords.FillColor = System.Drawing.Color.BurlyWood;
            this.grecords.FocusedColor = System.Drawing.Color.SandyBrown;
            this.grecords.Font = new System.Drawing.Font("Tahoma", 11F);
            this.grecords.ForeColor = System.Drawing.Color.Black;
            this.grecords.Location = new System.Drawing.Point(29, 317);
            this.grecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grecords.Name = "grecords";
            this.grecords.Size = new System.Drawing.Size(135, 34);
            this.grecords.TabIndex = 46;
            this.grecords.Text = "Records";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 43;
            // 
            // gtimeinout
            // 
            this.gtimeinout.AutoRoundedCorners = true;
            this.gtimeinout.BackColor = System.Drawing.Color.Transparent;
            this.gtimeinout.BorderRadius = 16;
            this.gtimeinout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gtimeinout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gtimeinout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gtimeinout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gtimeinout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gtimeinout.FillColor = System.Drawing.Color.BurlyWood;
            this.gtimeinout.FocusedColor = System.Drawing.Color.SandyBrown;
            this.gtimeinout.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gtimeinout.ForeColor = System.Drawing.Color.Black;
            this.gtimeinout.Location = new System.Drawing.Point(29, 253);
            this.gtimeinout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gtimeinout.Name = "gtimeinout";
            this.gtimeinout.Size = new System.Drawing.Size(135, 34);
            this.gtimeinout.TabIndex = 45;
            this.gtimeinout.Text = "Time In/Out";
            this.gtimeinout.Click += new System.EventHandler(this.gtimeinout_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Hello";
            // 
            // gaddStudent
            // 
            this.gaddStudent.AutoRoundedCorners = true;
            this.gaddStudent.BorderRadius = 16;
            this.gaddStudent.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gaddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gaddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gaddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gaddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gaddStudent.FillColor = System.Drawing.Color.BurlyWood;
            this.gaddStudent.FocusedColor = System.Drawing.Color.SandyBrown;
            this.gaddStudent.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gaddStudent.ForeColor = System.Drawing.Color.Black;
            this.gaddStudent.Location = new System.Drawing.Point(29, 190);
            this.gaddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gaddStudent.Name = "gaddStudent";
            this.gaddStudent.Size = new System.Drawing.Size(135, 34);
            this.gaddStudent.TabIndex = 44;
            this.gaddStudent.Text = "Add Student";
            this.gaddStudent.Click += new System.EventHandler(this.gaddStudent_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SandyBrown;
            this.button5.Location = new System.Drawing.Point(50, 510);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 39);
            this.button5.TabIndex = 41;
            this.button5.Text = "LogOut";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.LimeGreen;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LawnGreen;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightGreen;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Lime;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(15, 318);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(12, 32);
            this.guna2CustomGradientPanel1.TabIndex = 48;
            // 
            // Record2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1158, 603);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grecords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gtimeinout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gaddStudent);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Record2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record2";
            this.Load += new System.EventHandler(this.Record2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button grecords;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button gtimeinout;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button gaddStudent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}