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


namespace Bakerysystem
{
    public partial class Empolyee : Form
    {
        public Empolyee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Employee values(@name,@postion,@contact,@salary,@shift)", cn);
            cmd.Parameters.AddWithValue("@name", txtemployeename.Text);
            cmd.Parameters.AddWithValue("@postion", txtpostion.Text);
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@shift", txtcomboBox1.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();
            
        }
        void getdata()
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

            txtemployeename.Text = "";
            txtpostion.Text = "";
            txtcontact.Text = "";
            txtsalary.Text = "";
            txtcomboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("update employee set position=@postion,contact=@contact,salary=@salary,shift=@shift where emp_name=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtemployeename.Text);
            cmd.Parameters.AddWithValue("@postion", txtpostion.Text);
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@shift", txtcomboBox1.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            dataProvider();
        }

        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from Employee where emp_name=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtemployeename.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            dataProvider();
        }

        private void Empolyee_Load(object sender, EventArgs e)
        {
            dataProvider();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}