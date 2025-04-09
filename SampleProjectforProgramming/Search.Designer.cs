namespace SampleProjectforProgramming
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblProgram = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gaddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.grecords = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gtimeinout = new Guna.UI2.WinForms.Guna2Button();
            this.button5 = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(179, 25);
            this.Status.Text = "toolStripStatusLabel1";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(424, 11);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(193, 32);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "Time";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(166, 11);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(225, 32);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1087, 32);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblProgram
            // 
            this.lblProgram.Location = new System.Drawing.Point(434, 465);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(96, 26);
            this.lblProgram.TabIndex = 25;
            this.lblProgram.Text = "Program";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(371, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Student ID";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(574, 367);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(383, 39);
            this.txtName.TabIndex = 1;
            // 
            // txtProgram
            // 
            this.txtProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgram.Location = new System.Drawing.Point(574, 451);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgram.Multiline = true;
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(382, 40);
            this.txtProgram.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attendance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Location = new System.Drawing.Point(350, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 63);
            this.panel1.TabIndex = 16;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Location = new System.Drawing.Point(574, 288);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(383, 39);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Admin";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.button1);
            this.guna2Panel2.Controls.Add(this.button2);
            this.guna2Panel2.Controls.Add(this.button3);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Green;
            this.guna2Panel2.Location = new System.Drawing.Point(0, -2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1303, 90);
            this.guna2Panel2.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1019, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 27);
            this.label5.TabIndex = 37;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 56);
            this.label1.TabIndex = 36;
            this.label1.Text = "AttendScan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Records";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Time In/Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::SampleProjectforProgramming.Properties.Resources._440979595_1825340057973007_1015642796755802723_n_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(406, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hello";
            // 
            // gaddStudent
            // 
            this.gaddStudent.AutoRoundedCorners = true;
            this.gaddStudent.BorderRadius = 20;
            this.gaddStudent.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gaddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gaddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gaddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gaddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gaddStudent.FillColor = System.Drawing.Color.BurlyWood;
            this.gaddStudent.FocusedColor = System.Drawing.Color.SandyBrown;
            this.gaddStudent.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gaddStudent.ForeColor = System.Drawing.Color.Black;
            this.gaddStudent.Location = new System.Drawing.Point(53, 238);
            this.gaddStudent.Name = "gaddStudent";
            this.gaddStudent.Size = new System.Drawing.Size(152, 42);
            this.gaddStudent.TabIndex = 10;
            this.gaddStudent.Text = "Add Student";
            this.gaddStudent.Click += new System.EventHandler(this.gaddStudent_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.LimeGreen;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LawnGreen;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightGreen;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Lime;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(34, 317);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(14, 40);
            this.guna2CustomGradientPanel1.TabIndex = 14;
            // 
            // grecords
            // 
            this.grecords.AutoRoundedCorners = true;
            this.grecords.BackColor = System.Drawing.Color.Transparent;
            this.grecords.BorderRadius = 20;
            this.grecords.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.grecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.grecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.grecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.grecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.grecords.FillColor = System.Drawing.Color.BurlyWood;
            this.grecords.FocusedColor = System.Drawing.Color.SandyBrown;
            this.grecords.Font = new System.Drawing.Font("Tahoma", 11F);
            this.grecords.ForeColor = System.Drawing.Color.Black;
            this.grecords.Location = new System.Drawing.Point(53, 402);
            this.grecords.Name = "grecords";
            this.grecords.Size = new System.Drawing.Size(152, 42);
            this.grecords.TabIndex = 12;
            this.grecords.Text = "Records";
            this.grecords.Click += new System.EventHandler(this.grecords_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 7;
            // 
            // gtimeinout
            // 
            this.gtimeinout.AutoRoundedCorners = true;
            this.gtimeinout.BackColor = System.Drawing.Color.Transparent;
            this.gtimeinout.BorderRadius = 20;
            this.gtimeinout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gtimeinout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gtimeinout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gtimeinout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gtimeinout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gtimeinout.FillColor = System.Drawing.Color.BurlyWood;
            this.gtimeinout.FocusedColor = System.Drawing.Color.SandyBrown;
            this.gtimeinout.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gtimeinout.ForeColor = System.Drawing.Color.Black;
            this.gtimeinout.Location = new System.Drawing.Point(53, 317);
            this.gtimeinout.Name = "gtimeinout";
            this.gtimeinout.Size = new System.Drawing.Size(152, 42);
            this.gtimeinout.TabIndex = 11;
            this.gtimeinout.Text = "Time In/Out";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SandyBrown;
            this.button5.Location = new System.Drawing.Point(74, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "LogOut";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.Bisque;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 122;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2Panel1.Controls.Add(this.grecords);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.gtimeinout);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.gaddStudent);
            this.guna2Panel1.Controls.Add(this.button5);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Green;
            this.guna2Panel1.Location = new System.Drawing.Point(-13, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(246, 721);
            this.guna2Panel1.TabIndex = 34;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1087, 668);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time In";
            this.Load += new System.EventHandler(this.Search_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button gaddStudent;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button grecords;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button gtimeinout;
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}