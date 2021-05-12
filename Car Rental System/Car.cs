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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Tables for project\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from CarTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Unamebar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNobar.Text == "" || Brandbar.Text == "" || Modelbar.Text == "" || Pricebar.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into CarTable values('"+RegNobar.Text+"', '"+Brandbar.Text+"', '"+Modelbar.Text+"', '"+AvailableCb.SelectedItem.ToString()+"', '"+Pricebar.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNobar.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTable where RegNum = '"+ RegNobar.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNobar.Text = CarsDGV.SelectedRows[0].Cells[0].Value.ToString();
            Brandbar.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Modelbar.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.SelectedItem = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Pricebar.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNobar.Text == "" || Brandbar.Text == "" || Modelbar.Text == "" || Pricebar.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTable set Brand = '"+Brandbar.Text+"', Model = '"+Modelbar.Text+"', Available = '"+AvailableCb.SelectedItem.ToString()+"', Price = "+Pricebar.Text+" where RegNum = '"+RegNobar.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            RegNobar.Text = "";
            Brandbar.Text = "";
            Modelbar.Text = "";
            Pricebar.Text = "";
            AvailableCb.Text = "";
            Search.Text = "";
        }
    }
}
