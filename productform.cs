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
    public partial class productform: Form
    {
        public productform()
        {
            InitializeComponent();
        }

        private void productform_Load(object sender, EventArgs e)
        {
            dataProvider();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into productform values(@name,@productname,@category,@price,@indgredients,@StockAvailability)", cn);
            cmd.Parameters.AddWithValue("@productname", txtproduct.Text);
            cmd.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@indgredients",  txtindgred.Text);
            cmd.Parameters.AddWithValue("@StockAvailability ", txtchkStockAvailable.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into  Products values(@name,@productname,@category,@price,@indgredients,@StockAvailability)", cn);
            cmd.Parameters.AddWithValue("@productname", txtproduct.Text);
            cmd.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@indgredients", txtindgred.Text);
            cmd.Parameters.AddWithValue("@StockAvailability ", txtchkStockAvailable.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            dataProvider();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtproduct.Text = "";
            txtcategory.Text = "";
            txtprice.Text = "";
            txtindgred.Text = "";
             txtchkStockAvailable.Text = "";

        }

        private void listView1_Click(object sender, EventArgs e)
        {

           
        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from products ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from productform where  productname=@name", cn);
            cmd.Parameters.AddWithValue("@name", txtproduct.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            dataProvider();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtchkStockAvailable.Checked)
            {
                MessageBox.Show("This product is available in stock.");
            }
            else
            {
                MessageBox.Show("This product is out of stock.");
            }
        }
    }
}
