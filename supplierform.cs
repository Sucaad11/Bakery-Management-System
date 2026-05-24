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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bakerysystem
{
    public partial class supplierform: Form
    {
        public supplierform()
        {
            InitializeComponent();
        }

        
         

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Delivery values(@supplier,@name,@address,@status)", cn);
            cmd.Parameters.AddWithValue("@supplier", txtsupplier.Text);
            cmd.Parameters.AddWithValue("@name", txtcontact.Text);
            cmd.Parameters.AddWithValue("@address", txtlistBox1.Text);
            cmd.Parameters.AddWithValue("@status", txtcomboBox1.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            txtsupplier.Text = "";
            txtcontact.Text = "";
             txtlistBox1.Text = "";
            txtcomboBox1.Text = "";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Delivery values(@orderno,@name,@address,@status)", cn);
            cmd.Parameters.AddWithValue("@orderno", txtsupplier.Text);
            cmd.Parameters.AddWithValue("@name", txtcontact.Text);
            cmd.Parameters.AddWithValue("@address", txtlistBox1.Text);
            cmd.Parameters.AddWithValue("@status", txtcomboBox1.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            dataProvider();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from supplier where suppliername=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtsupplier.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            dataProvider();
        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from  Suppliers ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
          

        }

        private void supplierform_Load(object sender, EventArgs e)
        {
            dataProvider();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlistBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
