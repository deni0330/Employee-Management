namespace Project_MIP
{
    partial class EmployeeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeData));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchB = new System.Windows.Forms.Button();
            this.empIDSearch = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.empEdate = new System.Windows.Forms.Label();
            this.empPos = new System.Windows.Forms.Label();
            this.empEd = new System.Windows.Forms.Label();
            this.empPho = new System.Windows.Forms.Label();
            this.empAd = new System.Windows.Forms.Label();
            this.empBD = new System.Windows.Forms.Label();
            this.empGen = new System.Windows.Forms.Label();
            this.empLName = new System.Windows.Forms.Label();
            this.empFName = new System.Windows.Forms.Label();
            this.DeleteButon = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 768);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 59);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(542, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Software Ideea";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.SearchB);
            this.panel2.Controls.Add(this.empIDSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(72, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 70);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SearchB
            // 
            this.SearchB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchB.Location = new System.Drawing.Point(517, 21);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(94, 29);
            this.SearchB.TabIndex = 15;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.button1_Click);
            // 
            // empIDSearch
            // 
            this.empIDSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empIDSearch.Location = new System.Drawing.Point(175, 17);
            this.empIDSearch.Name = "empIDSearch";
            this.empIDSearch.Size = new System.Drawing.Size(310, 39);
            this.empIDSearch.TabIndex = 14;
            this.empIDSearch.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.empIDTb_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.empEdate);
            this.panel4.Controls.Add(this.empPos);
            this.panel4.Controls.Add(this.empEd);
            this.panel4.Controls.Add(this.empPho);
            this.panel4.Controls.Add(this.empAd);
            this.panel4.Controls.Add(this.empBD);
            this.panel4.Controls.Add(this.empGen);
            this.panel4.Controls.Add(this.empLName);
            this.panel4.Controls.Add(this.empFName);
            this.panel4.Controls.Add(this.DeleteButon);
            this.panel4.Controls.Add(this.UpdateButton);
            this.panel4.Controls.Add(this.AddButton);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(72, 240);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 486);
            this.panel4.TabIndex = 14;
            // 
            // empEdate
            // 
            this.empEdate.AutoSize = true;
            this.empEdate.BackColor = System.Drawing.Color.LavenderBlush;
            this.empEdate.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empEdate.ForeColor = System.Drawing.Color.Indigo;
            this.empEdate.Location = new System.Drawing.Point(780, 93);
            this.empEdate.Name = "empEdate";
            this.empEdate.Size = new System.Drawing.Size(181, 25);
            this.empEdate.TabIndex = 35;
            this.empEdate.Text = "Employment Date";
            this.empEdate.Visible = false;
            // 
            // empPos
            // 
            this.empPos.AutoSize = true;
            this.empPos.BackColor = System.Drawing.Color.LavenderBlush;
            this.empPos.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empPos.ForeColor = System.Drawing.Color.Indigo;
            this.empPos.Location = new System.Drawing.Point(780, 45);
            this.empPos.Name = "empPos";
            this.empPos.Size = new System.Drawing.Size(88, 25);
            this.empPos.TabIndex = 34;
            this.empPos.Text = "Position";
            this.empPos.Visible = false;
            // 
            // empEd
            // 
            this.empEd.AutoSize = true;
            this.empEd.BackColor = System.Drawing.Color.LavenderBlush;
            this.empEd.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empEd.ForeColor = System.Drawing.Color.Indigo;
            this.empEd.Location = new System.Drawing.Point(202, 381);
            this.empEd.Name = "empEd";
            this.empEd.Size = new System.Drawing.Size(108, 25);
            this.empEd.TabIndex = 33;
            this.empEd.Text = "Education";
            this.empEd.Visible = false;
            // 
            // empPho
            // 
            this.empPho.AutoSize = true;
            this.empPho.BackColor = System.Drawing.Color.LavenderBlush;
            this.empPho.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empPho.ForeColor = System.Drawing.Color.Indigo;
            this.empPho.Location = new System.Drawing.Point(202, 321);
            this.empPho.Name = "empPho";
            this.empPho.Size = new System.Drawing.Size(71, 25);
            this.empPho.TabIndex = 32;
            this.empPho.Text = "Phone";
            this.empPho.Visible = false;
            // 
            // empAd
            // 
            this.empAd.AutoSize = true;
            this.empAd.BackColor = System.Drawing.Color.LavenderBlush;
            this.empAd.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empAd.ForeColor = System.Drawing.Color.Indigo;
            this.empAd.Location = new System.Drawing.Point(202, 256);
            this.empAd.Name = "empAd";
            this.empAd.Size = new System.Drawing.Size(88, 25);
            this.empAd.TabIndex = 31;
            this.empAd.Text = "Address";
            this.empAd.Visible = false;
            // 
            // empBD
            // 
            this.empBD.AutoSize = true;
            this.empBD.BackColor = System.Drawing.Color.LavenderBlush;
            this.empBD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empBD.ForeColor = System.Drawing.Color.Indigo;
            this.empBD.Location = new System.Drawing.Point(202, 197);
            this.empBD.Name = "empBD";
            this.empBD.Size = new System.Drawing.Size(111, 25);
            this.empBD.TabIndex = 30;
            this.empBD.Text = "Birth Date";
            this.empBD.Visible = false;
            // 
            // empGen
            // 
            this.empGen.AutoSize = true;
            this.empGen.BackColor = System.Drawing.Color.LavenderBlush;
            this.empGen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empGen.ForeColor = System.Drawing.Color.Indigo;
            this.empGen.Location = new System.Drawing.Point(202, 147);
            this.empGen.Name = "empGen";
            this.empGen.Size = new System.Drawing.Size(82, 25);
            this.empGen.TabIndex = 29;
            this.empGen.Text = "Gender";
            this.empGen.Visible = false;
            // 
            // empLName
            // 
            this.empLName.AutoSize = true;
            this.empLName.BackColor = System.Drawing.Color.LavenderBlush;
            this.empLName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empLName.ForeColor = System.Drawing.Color.Indigo;
            this.empLName.Location = new System.Drawing.Point(202, 93);
            this.empLName.Name = "empLName";
            this.empLName.Size = new System.Drawing.Size(115, 25);
            this.empLName.TabIndex = 28;
            this.empLName.Text = "Last Name";
            this.empLName.Visible = false;
            // 
            // empFName
            // 
            this.empFName.AutoSize = true;
            this.empFName.BackColor = System.Drawing.Color.LavenderBlush;
            this.empFName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empFName.ForeColor = System.Drawing.Color.Indigo;
            this.empFName.Location = new System.Drawing.Point(202, 41);
            this.empFName.Name = "empFName";
            this.empFName.Size = new System.Drawing.Size(118, 25);
            this.empFName.TabIndex = 27;
            this.empFName.Text = "First Name";
            this.empFName.Visible = false;
            // 
            // DeleteButon
            // 
            this.DeleteButon.BackColor = System.Drawing.Color.Crimson;
            this.DeleteButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButon.Location = new System.Drawing.Point(427, 679);
            this.DeleteButon.Name = "DeleteButon";
            this.DeleteButon.Size = new System.Drawing.Size(100, 34);
            this.DeleteButon.TabIndex = 26;
            this.DeleteButon.Text = "Delete";
            this.DeleteButon.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(235, 679);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(101, 34);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(51, 679);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 34);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Lavender;
            this.label13.Location = new System.Drawing.Point(584, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Employment Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(584, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Position:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Lavender;
            this.label11.Location = new System.Drawing.Point(45, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Education:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(82, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lavender;
            this.label9.Location = new System.Drawing.Point(70, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(47, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Birth Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(71, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(47, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(51, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(173, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Data";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1143, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(1087, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Back to my Page";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1247, 816);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeData";
            this.Text = "EmployeeData";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox empIDSearch;
        private System.Windows.Forms.Button SearchB;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeleteButon;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label empEdate;
        private System.Windows.Forms.Label empPos;
        private System.Windows.Forms.Label empLName;
        private System.Windows.Forms.Label empFName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label empEd;
        private System.Windows.Forms.Label empPho;
        private System.Windows.Forms.Label empAd;
        private System.Windows.Forms.Label empBD;
        private System.Windows.Forms.Label empGen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}