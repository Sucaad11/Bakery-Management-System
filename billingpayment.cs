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
    public partial class billingpayment: Form
    {
        public billingpayment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string invoiceNumber = "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtInvoiceNumber.Text = invoiceNumber;


        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from billings ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS; initial catalog=Bakerysystem; integrated security=True");
             
            SqlCommand cmd = new SqlCommand("INSERT INTO billings (name, ordernum, total, payment, invoice) VALUES (@name, @ordernum, @total, @payment, @invoice)", cn);

            
            cmd.Parameters.AddWithValue("@name", txtcustomer.Text);
            cmd.Parameters.AddWithValue("@ordernum", txtodernum.Text); // sax ah
            cmd.Parameters.AddWithValue("@total", txttotal.Text);
            cmd.Parameters.AddWithValue("@payment", txtpayment.Text);
            cmd.Parameters.AddWithValue("@invoice", txtInvoiceNumber.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Saved");
            dataProvider();

        }

        private void billingpayment_Load(object sender, EventArgs e)
        {
            dataProvider();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
