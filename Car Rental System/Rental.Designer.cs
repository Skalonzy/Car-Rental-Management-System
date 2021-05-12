namespace Car_Rental_System
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RentalDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.RID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.RFeees = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustIDCb = new System.Windows.Forms.ComboBox();
            this.RFees = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RentalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 680);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 22);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 97);
            this.panel1.TabIndex = 28;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(5, 3);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(119, 83);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 8;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(891, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(443, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(286, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental Management System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(19, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 68;
            this.label6.Text = "Rental Date:";
            // 
            // RentalDGV
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.RentalDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.RentalDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentalDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentalDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RentalDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentalDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.RentalDGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentalDGV.DefaultCellStyle = dataGridViewCellStyle21;
            this.RentalDGV.EnableHeadersVisualStyles = false;
            this.RentalDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentalDGV.Location = new System.Drawing.Point(367, 159);
            this.RentalDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RentalDGV.Name = "RentalDGV";
            this.RentalDGV.RowHeadersVisible = false;
            this.RentalDGV.RowTemplate.Height = 24;
            this.RentalDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentalDGV.Size = new System.Drawing.Size(552, 505);
            this.RentalDGV.TabIndex = 67;
            this.RentalDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.RentalDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RentalDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RentalDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RentalDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RentalDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RentalDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RentalDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentalDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.RentalDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RentalDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RentalDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RentalDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.RentalDGV.ThemeStyle.ReadOnly = false;
            this.RentalDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RentalDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentalDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RentalDGV.ThemeStyle.RowsStyle.Height = 24;
            this.RentalDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RentalDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RentalDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(139, 602);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 27);
            this.button4.TabIndex = 66;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(242, 568);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 27);
            this.button3.TabIndex = 65;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(139, 568);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 64;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(46, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 63;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RName
            // 
            this.RName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RName.ForeColor = System.Drawing.Color.Black;
            this.RName.HintForeColor = System.Drawing.Color.Empty;
            this.RName.HintText = "";
            this.RName.isPassword = false;
            this.RName.LineFocusedColor = System.Drawing.Color.Gray;
            this.RName.LineIdleColor = System.Drawing.Color.Brown;
            this.RName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.RName.LineThickness = 3;
            this.RName.Location = new System.Drawing.Point(154, 318);
            this.RName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(192, 36);
            this.RName.TabIndex = 62;
            this.RName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Name:";
            // 
            // RID
            // 
            this.RID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RID.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RID.ForeColor = System.Drawing.Color.Black;
            this.RID.HintForeColor = System.Drawing.Color.Empty;
            this.RID.HintText = "";
            this.RID.isPassword = false;
            this.RID.LineFocusedColor = System.Drawing.Color.Gray;
            this.RID.LineIdleColor = System.Drawing.Color.Brown;
            this.RID.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.RID.LineThickness = 3;
            this.RID.Location = new System.Drawing.Point(154, 144);
            this.RID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RID.Name = "RID";
            this.RID.Size = new System.Drawing.Size(192, 37);
            this.RID.TabIndex = 59;
            this.RID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(19, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 58;
            this.label8.Text = "CustID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(587, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cars For Rent";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(19, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "CarReg:";
            // 
            // CarRegCb
            // 
            this.CarRegCb.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.CarRegCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CarRegCb.Location = new System.Drawing.Point(154, 217);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(192, 25);
            this.CarRegCb.TabIndex = 71;
            this.CarRegCb.SelectionChangeCommitted += new System.EventHandler(this.CarRegCb_SelectionChangeCommitted);
            // 
            // RFeees
            // 
            this.RFeees.AutoSize = true;
            this.RFeees.BackColor = System.Drawing.Color.Gold;
            this.RFeees.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFeees.ForeColor = System.Drawing.Color.Red;
            this.RFeees.Location = new System.Drawing.Point(19, 496);
            this.RFeees.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RFeees.Name = "RFeees";
            this.RFeees.Size = new System.Drawing.Size(57, 21);
            this.RFeees.TabIndex = 72;
            this.RFeees.Text = "Fees:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(19, 447);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 75;
            this.label10.Text = "Return Date:";
            // 
            // CustIDCb
            // 
            this.CustIDCb.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.CustIDCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.CustIDCb.FormattingEnabled = true;
            this.CustIDCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CustIDCb.Location = new System.Drawing.Point(154, 272);
            this.CustIDCb.Name = "CustIDCb";
            this.CustIDCb.Size = new System.Drawing.Size(192, 25);
            this.CustIDCb.TabIndex = 77;
            this.CustIDCb.SelectionChangeCommitted += new System.EventHandler(this.CustIDCb_SelectionChangeCommitted);
            // 
            // RFees
            // 
            this.RFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RFees.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFees.ForeColor = System.Drawing.Color.Black;
            this.RFees.HintForeColor = System.Drawing.Color.Empty;
            this.RFees.HintText = "";
            this.RFees.isPassword = false;
            this.RFees.LineFocusedColor = System.Drawing.Color.Gray;
            this.RFees.LineIdleColor = System.Drawing.Color.Brown;
            this.RFees.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.RFees.LineThickness = 3;
            this.RFees.Location = new System.Drawing.Point(154, 481);
            this.RFees.Margin = new System.Windows.Forms.Padding(5);
            this.RFees.Name = "RFees";
            this.RFees.Size = new System.Drawing.Size(192, 36);
            this.RFees.TabIndex = 78;
            this.RFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ReturnDate
            // 
            this.ReturnDate.CheckedState.Parent = this.ReturnDate;
            this.ReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReturnDate.HoverState.Parent = this.ReturnDate;
            this.ReturnDate.Location = new System.Drawing.Point(154, 447);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ShadowDecoration.Parent = this.ReturnDate;
            this.ReturnDate.Size = new System.Drawing.Size(192, 26);
            this.ReturnDate.TabIndex = 80;
            this.ReturnDate.Value = new System.DateTime(2021, 5, 5, 15, 36, 20, 131);
            // 
            // RentalDate
            // 
            this.RentalDate.CheckedState.Parent = this.RentalDate;
            this.RentalDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RentalDate.HoverState.Parent = this.RentalDate;
            this.RentalDate.Location = new System.Drawing.Point(154, 389);
            this.RentalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RentalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.ShadowDecoration.Parent = this.RentalDate;
            this.RentalDate.Size = new System.Drawing.Size(192, 28);
            this.RentalDate.TabIndex = 81;
            this.RentalDate.Value = new System.DateTime(2021, 5, 5, 15, 36, 20, 131);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(380, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "SOUL SPARTANS";
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 702);
            this.Controls.Add(this.RentalDate);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RFees);
            this.Controls.Add(this.CustIDCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RFeees);
            this.Controls.Add(this.CarRegCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RentalDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDataGridView RentalDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CarRegCb;
        private System.Windows.Forms.Label RFeees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CustIDCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RFees;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker RentalDate;
        private System.Windows.Forms.Label label11;
    }
}