namespace Bakerysystem
{
    partial class customerform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerform));
            this.button1 = new System.Windows.Forms.Button();
            this.dtppickup = new System.Windows.Forms.DateTimePicker();
            this.txtcumtomername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.txtorderitems = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtoderitem = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(932, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtppickup
            // 
            this.dtppickup.Location = new System.Drawing.Point(217, 420);
            this.dtppickup.Name = "dtppickup";
            this.dtppickup.Size = new System.Drawing.Size(236, 20);
            this.dtppickup.TabIndex = 29;
            this.dtppickup.Value = new System.DateTime(2025, 4, 17, 0, 0, 0, 0);
            // 
            // txtcumtomername
            // 
            this.txtcumtomername.Location = new System.Drawing.Point(217, 172);
            this.txtcumtomername.Multiline = true;
            this.txtcumtomername.Name = "txtcumtomername";
            this.txtcumtomername.Size = new System.Drawing.Size(238, 25);
            this.txtcumtomername.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pickup Time:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPrice.Location = new System.Drawing.Point(62, 367);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(116, 24);
            this.labelTotalPrice.TabIndex = 23;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Red;
            this.txtQuantity.Location = new System.Drawing.Point(70, 323);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 24);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.Text = "Quantity:";
            // 
            // txtorderitems
            // 
            this.txtorderitems.AutoSize = true;
            this.txtorderitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderitems.ForeColor = System.Drawing.Color.Red;
            this.txtorderitems.Location = new System.Drawing.Point(70, 246);
            this.txtorderitems.Name = "txtorderitems";
            this.txtorderitems.Size = new System.Drawing.Size(125, 24);
            this.txtorderitems.TabIndex = 21;
            this.txtorderitems.Text = "Order Items:";
            // 
            // txtcustomer
            // 
            this.txtcustomer.AutoSize = true;
            this.txtcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.ForeColor = System.Drawing.Color.Red;
            this.txtcustomer.Location = new System.Drawing.Point(29, 173);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(166, 24);
            this.txtcustomer.TabIndex = 20;
            this.txtcustomer.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer form";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(449, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 58);
            this.button2.TabIndex = 31;
            this.button2.Text = "Submit Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(269, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 47);
            this.button3.TabIndex = 46;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(408, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 44);
            this.button4.TabIndex = 47;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(540, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 44);
            this.button5.TabIndex = 48;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(693, 476);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 44);
            this.button6.TabIndex = 49;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtoderitem
            // 
            this.txtoderitem.FormattingEnabled = true;
            this.txtoderitem.Items.AddRange(new object[] {
            "1. full cake with cream",
            "2. cup cakes",
            "3.sweets"});
            this.txtoderitem.Location = new System.Drawing.Point(227, 246);
            this.txtoderitem.Name = "txtoderitem";
            this.txtoderitem.Size = new System.Drawing.Size(236, 21);
            this.txtoderitem.TabIndex = 52;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(224, 323);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(247, 20);
            this.txtqty.TabIndex = 53;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(208, 371);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(245, 20);
            this.txtprice.TabIndex = 54;
            this.txtprice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-15, -15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 271);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1076, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtoderitem);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtppickup);
            this.Controls.Add(this.txtcumtomername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtorderitems);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerform";
            this.Load += new System.EventHandler(this.customerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtppickup;
        private System.Windows.Forms.TextBox txtcumtomername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.Label txtorderitems;
        private System.Windows.Forms.Label txtcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox txtoderitem;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}