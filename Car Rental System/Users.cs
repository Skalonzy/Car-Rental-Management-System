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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from UserTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UIDbar.Text == "" || Unamebar.Text == "" || Upassbar.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into UserTable values("+UIDbar.Text+", '"+Unamebar.Text+"', '"+Upassbar.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();
                }

                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(UIDbar.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTable where ID = " + UIDbar.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UIDbar.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            Unamebar.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upassbar.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UIDbar.Text == "" || Unamebar.Text == "" || Upassbar.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTable set UserName = '" + Unamebar.Text + "', UserPassword = '" + Upassbar.Text + "' where ID = " + UIDbar.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            UIDbar.Text = "";
            Unamebar.Text = "";
            Upassbar.Text = "";
        }
    }
}
