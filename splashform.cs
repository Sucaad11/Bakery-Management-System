using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakerysystem
{
    public partial class splashform: Form
    {
        public splashform()
        {
            InitializeComponent();
        }

        private void splashform_Load(object sender, EventArgs e)
        {

         
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
                 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
