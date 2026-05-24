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
    public partial class inventorytrackingform : Form
    {
        public inventorytrackingform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory VALUES(@IngredientName, @Quantity, @ExpireDate, @Supplier, @RestockDate)", cn);

            cmd.Parameters.AddWithValue("@IngredientName", txtindgred.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtnumericUpDown3.Text);
            cmd.Parameters.AddWithValue("@ExpireDate", txtdateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Supplier", txtcomboBox1.Text);
            cmd.Parameters.AddWithValue("@RestockDate", txtdateTimePicker2.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtindgred.Text = "";
            txtnumericUpDown3.Text = "";
            txtdateTimePicker1.Text = "";
            txtcomboBox1.Text = "";
            txtdateTimePicker2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory VALUES(@IngredientName, @Quantity, @ExpireDate, @Supplier, @RestockDate)", cn);

            cmd.Parameters.AddWithValue("@IngredientName", txtindgred.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtnumericUpDown3.Text);
            cmd.Parameters.AddWithValue("@ExpireDate", txtdateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Supplier", txtcomboBox1.Text);
            cmd.Parameters.AddWithValue("@RestockDate", txtdateTimePicker2.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            dataProvider();
        }

        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory", cn);
            DataTable dt = new DataTable();
            da.Fill(dt); 
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE IngredientName = @IngredientName", cn);
            cmd.Parameters.AddWithValue("@IngredientName", txtindgred.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            dataProvider();
        }

        private void inventorytrackingform_Load(object sender, EventArgs e)
        {
            dataProvider();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }
    }
}
