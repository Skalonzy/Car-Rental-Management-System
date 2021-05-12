using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            PassTb.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String query = "select count(*) from UserTable where Username = '" +Uname.Text+ "' and Userpassword = '" +PassTb.Text+ "'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
