using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from RentalTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            rentalDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateReturn()
        {
            Con.Open();
            string query = "select * from ReturnTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Deleteonreturn()
        {
            int rentID;
            rentID = Convert.ToInt32(rentalDGV.SelectedRows[0].Cells[0].Value.ToString());

            Con.Open();
            string query = "delete from RentalTable where RentID = " +rentID+ ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Rental Deleted Successfully");
            Con.Close();
            populate();
            //UpdateonRentDelete();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateReturn();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnCarID.Text = rentalDGV.SelectedRows[0].Cells[1].Value.ToString();
            ReturnName.Text = rentalDGV.SelectedRows[0].Cells[2].Value.ToString();
            ReturnDate.Text = rentalDGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfdays = Convert.ToInt32(t.TotalDays);

            if(NrOfdays <= 0)
            {
                ReturnDelay.Text = "No Delay";
                ReturnFine.Text = "0";
            }

            else
            {
                ReturnDelay.Text = "" + NrOfdays;
                ReturnFine.Text = "" + (NrOfdays * 250);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReturnID.Text == "" || ReturnName.Text == "" || ReturnFine.Text == "" || ReturnDelay.Text == "" || ReturnDelay.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into ReturnTable values(" + ReturnID.Text + ",'" + ReturnCarID.Text + "', '" + ReturnName.Text + "','" + ReturnDate.Text + "','" + ReturnDelay.Text + "','" +ReturnFine.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car dully returned");
                    Con.Close();
                    //UpdateonRent();
                    populateReturn();
                    Deleteonreturn();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
