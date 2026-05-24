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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bakerysystem
{
    public partial class Delivery: Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from delivery ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Delivery values(@orderno,@name,@address,@status)", cn);
            cmd.Parameters.AddWithValue("@orderno", txtordername.Text);
            cmd.Parameters.AddWithValue("@name", txtcustomername.Text);
            cmd.Parameters.AddWithValue("@address", txtdeliveryaddress.Text);
            cmd.Parameters.AddWithValue("@status", combobx.Text);
             
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();
          




           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtordername.Text = "";
            txtcustomername.Text = "";
             combobx.Text = "";
            txtdeliveryaddress.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("update delivery set cust_name=@cus_name,address=@address,status=@status where orderno=@orderno", cn);
            cmd.Parameters.AddWithValue("@orderno", txtordername.Text);
            cmd.Parameters.AddWithValue("@cus_name", txtcustomername.Text);
            cmd.Parameters.AddWithValue("@address", txtdeliveryaddress.Text);
            cmd.Parameters.AddWithValue("@status", combobx.Text);
;
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            dataProvider();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from customer where ordername=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtordername.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            dataProvider();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            dataProvider();
           
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
