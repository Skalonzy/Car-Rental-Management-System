namespace Car_Rental_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 84);
            this.panel1.TabIndex = 3;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(4, 3);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(102, 72);
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
            this.label2.Location = new System.Drawing.Point(896, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label5.Location = new System.Drawing.Point(384, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 688);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 24);
            this.panel2.TabIndex = 26;
            // 
            // CPhone
            // 
            this.CPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPhone.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPhone.ForeColor = System.Drawing.Color.Black;
            this.CPhone.HintForeColor = System.Drawing.Color.Empty;
            this.CPhone.HintText = "";
            this.CPhone.isPassword = false;
            this.CPhone.LineFocusedColor = System.Drawing.Color.Gray;
            this.CPhone.LineIdleColor = System.Drawing.Color.Brown;
            this.CPhone.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CPhone.LineThickness = 3;
            this.CPhone.Location = new System.Drawing.Point(134, 269);
            this.CPhone.Margin = new System.Windows.Forms.Padding(4);
            this.CPhone.Name = "CPhone";
            this.CPhone.Size = new System.Drawing.Size(218, 31);
            this.CPhone.TabIndex = 55;
            this.CPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(18, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Phone:";
            // 
            // CustomerDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CustomerDGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerDGV.EnableHeadersVisualStyles = false;
            this.CustomerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.Location = new System.Drawing.Point(361, 136);
            this.CustomerDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.RowTemplate.Height = 24;
            this.CustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDGV.Size = new System.Drawing.Size(559, 546);
            this.CustomerDGV.TabIndex = 53;
            this.CustomerDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.CustomerDGV.ThemeStyle.ReadOnly = false;
            this.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(134, 420);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 52;
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
            this.button3.Location = new System.Drawing.Point(222, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 51;
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
            this.button2.Location = new System.Drawing.Point(134, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 50;
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
            this.button1.Location = new System.Drawing.Point(54, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CAddress
            // 
            this.CAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CAddress.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAddress.ForeColor = System.Drawing.Color.Black;
            this.CAddress.HintForeColor = System.Drawing.Color.Empty;
            this.CAddress.HintText = "";
            this.CAddress.isPassword = false;
            this.CAddress.LineFocusedColor = System.Drawing.Color.Gray;
            this.CAddress.LineIdleColor = System.Drawing.Color.Brown;
            this.CAddress.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CAddress.LineThickness = 3;
            this.CAddress.Location = new System.Drawing.Point(134, 221);
            this.CAddress.Margin = new System.Windows.Forms.Padding(4);
            this.CAddress.Name = "CAddress";
            this.CAddress.Size = new System.Drawing.Size(218, 31);
            this.CAddress.TabIndex = 48;
            this.CAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Address:";
            // 
            // CName
            // 
            this.CName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.ForeColor = System.Drawing.Color.Black;
            this.CName.HintForeColor = System.Drawing.Color.Empty;
            this.CName.HintText = "";
            this.CName.isPassword = false;
            this.CName.LineFocusedColor = System.Drawing.Color.Gray;
            this.CName.LineIdleColor = System.Drawing.Color.Brown;
            this.CName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CName.LineThickness = 3;
            this.CName.Location = new System.Drawing.Point(134, 169);
            this.CName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(218, 33);
            this.CName.TabIndex = 46;
            this.CName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CID
            // 
            this.CID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CID.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID.ForeColor = System.Drawing.Color.Black;
            this.CID.HintForeColor = System.Drawing.Color.Empty;
            this.CID.HintText = "";
            this.CID.isPassword = false;
            this.CID.LineFocusedColor = System.Drawing.Color.Gray;
            this.CID.LineIdleColor = System.Drawing.Color.Brown;
            this.CID.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CID.LineThickness = 3;
            this.CID.Location = new System.Drawing.Point(134, 125);
            this.CID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(218, 32);
            this.CID.TabIndex = 45;
            this.CID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(18, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(18, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(599, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Customer List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(380, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "SOUL SPARTANS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(139, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Clear";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 712);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CPhone;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDataGridView CustomerDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CAddress;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}