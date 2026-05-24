using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakerysystem
{
    public partial class home: Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            customerform customerform = new customerform();
            customerform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            productform productform = new productform();
            productform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            supplierform supplierform = new supplierform();
            supplierform.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            inventorytrackingform inventorytrackingform = new inventorytrackingform();
            inventorytrackingform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           billingpayment billingpayment= new  billingpayment();
          billingpayment.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        Empolyee  empolyee = new  Empolyee();
            empolyee.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Feedback feedback = new  Feedback();
             feedback.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Delivery delivery = new  Delivery();
             delivery.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
