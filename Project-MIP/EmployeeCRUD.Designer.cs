namespace Project_MIP
{
    partial class EmployeeCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeCRUD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.empIDTb = new System.Windows.Forms.MaskedTextBox();
            this.DeleteButon = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.empEmploymentDateD = new System.Windows.Forms.DateTimePicker();
            this.empBirthDateD = new System.Windows.Forms.DateTimePicker();
            this.empEducationTb = new System.Windows.Forms.ComboBox();
            this.empPositionDb = new System.Windows.Forms.ComboBox();
            this.empGenderDb = new System.Windows.Forms.ComboBox();
            this.empPhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.empFirstNameTb = new System.Windows.Forms.MaskedTextBox();
            this.empLastNameTb = new System.Windows.Forms.MaskedTextBox();
            this.empAddressTb = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.ForeColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(-3, -2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1828, 86);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(1662, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Back to my Page";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1722, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Add, Update, Delete";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, 880);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1828, 63);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(931, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Software Ideea";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.empIDTb);
            this.panel1.Controls.Add(this.DeleteButon);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.empEmploymentDateD);
            this.panel1.Controls.Add(this.empBirthDateD);
            this.panel1.Controls.Add(this.empEducationTb);
            this.panel1.Controls.Add(this.empPositionDb);
            this.panel1.Controls.Add(this.empGenderDb);
            this.panel1.Controls.Add(this.empPhoneTb);
            this.panel1.Controls.Add(this.empFirstNameTb);
            this.panel1.Controls.Add(this.empLastNameTb);
            this.panel1.Controls.Add(this.empAddressTb);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(45, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 744);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(120, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // empIDTb
            // 
            this.empIDTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empIDTb.Location = new System.Drawing.Point(195, 138);
            this.empIDTb.Name = "empIDTb";
            this.empIDTb.ReadOnly = true;
            this.empIDTb.Size = new System.Drawing.Size(310, 30);
            this.empIDTb.TabIndex = 27;
            this.empIDTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.empIDTb_MaskInputRejected);
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
            this.DeleteButon.Click += new System.EventHandler(this.DeleteButon_Click);
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
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // empEmploymentDateD
            // 
            this.empEmploymentDateD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empEmploymentDateD.Location = new System.Drawing.Point(214, 617);
            this.empEmploymentDateD.Name = "empEmploymentDateD";
            this.empEmploymentDateD.Size = new System.Drawing.Size(313, 30);
            this.empEmploymentDateD.TabIndex = 22;
            // 
            // empBirthDateD
            // 
            this.empBirthDateD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empBirthDateD.Location = new System.Drawing.Point(195, 340);
            this.empBirthDateD.Name = "empBirthDateD";
            this.empBirthDateD.Size = new System.Drawing.Size(310, 30);
            this.empBirthDateD.TabIndex = 21;
            this.empBirthDateD.ValueChanged += new System.EventHandler(this.empBirthDateD_ValueChanged);
            // 
            // empEducationTb
            // 
            this.empEducationTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empEducationTb.FormattingEnabled = true;
            this.empEducationTb.Items.AddRange(new object[] {
            "Lucian Blaga University of Sibiu",
            "Transilvania University of Brasov",
            "University POLITEHNICA of Bucharest",
            "Babes-Bolyai University",
            "Technical University of Cluj-Napoca",
            "Politehnica University of Timişoara"});
            this.empEducationTb.Location = new System.Drawing.Point(195, 490);
            this.empEducationTb.Name = "empEducationTb";
            this.empEducationTb.Size = new System.Drawing.Size(310, 31);
            this.empEducationTb.TabIndex = 20;
            this.empEducationTb.SelectedIndexChanged += new System.EventHandler(this.empEducationTb_SelectedIndexChanged);
            // 
            // empPositionDb
            // 
            this.empPositionDb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empPositionDb.FormattingEnabled = true;
            this.empPositionDb.Items.AddRange(new object[] {
            "Engineering Project Manager",
            "Software Architect",
            "Product owner",
            "Technical Lead",
            "Quality Assurance Engineer",
            "Human Resources",
            "Internship"});
            this.empPositionDb.Location = new System.Drawing.Point(214, 565);
            this.empPositionDb.Name = "empPositionDb";
            this.empPositionDb.Size = new System.Drawing.Size(313, 31);
            this.empPositionDb.TabIndex = 19;
            this.empPositionDb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // empGenderDb
            // 
            this.empGenderDb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empGenderDb.FormattingEnabled = true;
            this.empGenderDb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.empGenderDb.Location = new System.Drawing.Point(195, 288);
            this.empGenderDb.Name = "empGenderDb";
            this.empGenderDb.Size = new System.Drawing.Size(310, 31);
            this.empGenderDb.TabIndex = 18;
            this.empGenderDb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empPhoneTb
            // 
            this.empPhoneTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empPhoneTb.Location = new System.Drawing.Point(195, 441);
            this.empPhoneTb.Name = "empPhoneTb";
            this.empPhoneTb.Size = new System.Drawing.Size(310, 30);
            this.empPhoneTb.TabIndex = 17;
            // 
            // empFirstNameTb
            // 
            this.empFirstNameTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empFirstNameTb.Location = new System.Drawing.Point(195, 190);
            this.empFirstNameTb.Name = "empFirstNameTb";
            this.empFirstNameTb.Size = new System.Drawing.Size(310, 30);
            this.empFirstNameTb.TabIndex = 16;
            this.empFirstNameTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.empFirstNameTb_MaskInputRejected);
            // 
            // empLastNameTb
            // 
            this.empLastNameTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empLastNameTb.Location = new System.Drawing.Point(195, 236);
            this.empLastNameTb.Name = "empLastNameTb";
            this.empLastNameTb.Size = new System.Drawing.Size(310, 30);
            this.empLastNameTb.TabIndex = 15;
            // 
            // empAddressTb
            // 
            this.empAddressTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empAddressTb.Location = new System.Drawing.Point(195, 390);
            this.empAddressTb.Name = "empAddressTb";
            this.empAddressTb.Size = new System.Drawing.Size(310, 30);
            this.empAddressTb.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Lavender;
            this.label13.Location = new System.Drawing.Point(20, 617);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Employment Date:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(113, 571);
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
            this.label11.Location = new System.Drawing.Point(42, 496);
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
            this.label10.Location = new System.Drawing.Point(76, 446);
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
            this.label9.Location = new System.Drawing.Point(62, 390);
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
            this.label8.Location = new System.Drawing.Point(39, 344);
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
            this.label7.Location = new System.Drawing.Point(65, 294);
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
            this.label6.Location = new System.Drawing.Point(42, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(42, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // empGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empGrid.BackgroundColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empGrid.ColumnHeadersHeight = 50;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.empGrid.GridColor = System.Drawing.Color.Lavender;
            this.empGrid.Location = new System.Drawing.Point(646, 114);
            this.empGrid.Name = "empGrid";
            this.empGrid.RowHeadersVisible = false;
            this.empGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.empGrid.RowTemplate.Height = 29;
            this.empGrid.Size = new System.Drawing.Size(1141, 744);
            this.empGrid.TabIndex = 15;
            this.empGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empGrid.ThemeStyle.BackColor = System.Drawing.Color.Indigo;
            this.empGrid.ThemeStyle.GridColor = System.Drawing.Color.Lavender;
            this.empGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.empGrid.ThemeStyle.ReadOnly = false;
            this.empGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empGrid.ThemeStyle.RowsStyle.Height = 29;
            this.empGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // EmployeeCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1819, 938);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "EmployeeCRUD";
            this.Text = "MainPageA";
            this.Load += new System.EventHandler(this.MainPageA_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker empBirthDateD;
        private System.Windows.Forms.ComboBox empEducationTb;
        private System.Windows.Forms.ComboBox empPositionDb;
        private System.Windows.Forms.ComboBox empGenderDb;
        private System.Windows.Forms.MaskedTextBox empPhoneTb;
        private System.Windows.Forms.MaskedTextBox empFirstNameTb;
        private System.Windows.Forms.MaskedTextBox empLastNameTb;
        private System.Windows.Forms.MaskedTextBox empAddressTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker empEmploymentDateD;
        private System.Windows.Forms.Button DeleteButon;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private Guna.UI2.WinForms.Guna2DataGridView empGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox empIDTb;
    }
}