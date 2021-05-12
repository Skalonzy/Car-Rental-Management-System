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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CID.Text == "" || CName.Text == "" || CAddress.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into CustomerTable values(" + CID.Text + ", '" + CName.Text + "', '" + CAddress.Text + "', '" + CPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTable where CustomerID = " + CID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CID.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            CName.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAddress.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CPhone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CID.Text == "" || CName.Text == "" || CAddress.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTable set CustomerName = '" +CName.Text+ "', CustomerAdd = '" +CAddress.Text+ "', Phone = '" +CPhone.Text+ "' where CustomerID =" +CID.Text+ ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CID.Text = "";
            CName.Text = "";
            CAddress.Text = "";
            CPhone.Text = "";
        }
    }
}
