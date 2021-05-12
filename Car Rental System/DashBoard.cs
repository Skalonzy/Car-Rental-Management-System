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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string querycar = "select Count(*) from CarTable";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CarLb1.Text = dt.Rows[0][0].ToString();

            string querycust = "select Count(*) from CustomerTable";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CustLb.Text = dt1.Rows[0][0].ToString();

            string queryuser = "select Count(*) from UserTable";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserLb.Text = dt2.Rows[0][0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
