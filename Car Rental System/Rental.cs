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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillcombo()
        {
            Con.Open();
            string query = "select RegNum from CarTable where Available  = '"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNum";
            CarRegCb.DataSource = dt;
            Con.Close();
        }

        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustomerID from CustomerTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Load(rdr);
            CustIDCb.ValueMember = "CustomerID";
            CustIDCb.DataSource = dt;
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CustomerTable where CustomerID = " + CustIDCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                RName.Text = dr["CustomerName"].ToString();
            }
            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from RentalTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentalDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void UpdateonRent()
        {
            Con.Open();
            string query = "update CarTable set Available = '" + "No" + "' where RegNum = '" +CarRegCb.SelectedValue.ToString()+ "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }

        private void UpdateonRentDelete()
        {
            Con.Open();
            string query = "update CarTable set Available = '" + "Yes" + "' where RegNum = '" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }

        private void CustIDCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RID.Text = RentalDGV.SelectedRows[0].Cells[0].Value.ToString();
            CarRegCb.SelectedValue = RentalDGV.SelectedRows[0].Cells[1].Value.ToString();
            //CustIDCb.Text = RentalDGV.SelectedRows[0].Cells[3].Value.ToString();
            RFees.Text = RentalDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RID.Text == "" || RName.Text == "" || RFees.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into RentalTable values(" +RID.Text+ ", '" +CarRegCb.SelectedValue.ToString()+ "', '" +RName.Text+ "','" +RentalDate.Text+ "','" +ReturnDate.Text+ "'," +RFees.Text+")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    UpdateonRent();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from RentalTable where RentID = " + RID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
                    Con.Close();
                    populate();
                    UpdateonRentDelete();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
