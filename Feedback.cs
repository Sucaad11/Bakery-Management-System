using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bakerysystem
{
    public partial class Feedback: Form
    {
        public Feedback()
        {
            InitializeComponent();
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your feedback has been submitted successfully!");
            
            
           

            

        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            dataProvider();

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }
        void dataProvider()
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from delivery ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source=DESKTOP-LJUL734\\SQLEXPRESS;initial catalog=BakeryManagement;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into Delivery values(@orderno,@name,@address,@status)", cn);
            cmd.Parameters.AddWithValue("@orderno", txtcustomer.Text);
            cmd.Parameters.AddWithValue("@name", txtorder.Text);
            cmd.Parameters.AddWithValue("@address", txtcombox1.Text);
            cmd.Parameters.AddWithValue("@status", txtcomplaint.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            dataProvider();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
