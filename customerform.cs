using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakerysystem
{
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from customer where CustoName=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtcumtomername.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            dataProvider();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Customer values(@name,@orderitem,@qty,@price,@pickup)", cn);
            cmd.Parameters.AddWithValue("@name", txtcumtomername.Text);
            cmd.Parameters.AddWithValue("@orderitem", txtoderitem.Text);
            cmd.Parameters.AddWithValue("@qty", txtqty.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@pickup", dtppickup.Value);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcumtomername.Text = "";
             txtoderitem.Text = "";
            txtcumtomername. Text = "";
             button6.Text = "";
            dtppickup.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("update Customer set oderitem=@orderitem,qty=@qty,price=@price,pickup=@pickup where custoName=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtcumtomername.Text);
            cmd.Parameters.AddWithValue("@orderitem", txtoderitem.Text);
            cmd.Parameters.AddWithValue("@qty", txtqty.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@pickup", dtppickup.Value);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            dataProvider();
        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from customer ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void customerform_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from customer ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been submitted");
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            


        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}