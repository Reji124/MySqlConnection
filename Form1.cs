using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mysqlConnection_Aguio.myclass;

namespace mysqlConnection_Aguio
{
    public partial class Form1 : Form
    {
        connection_class con = new connection_class();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(935, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    con.connectdb.Open();
                    label2.Text = "You are Connected to the MySql Database!";
                    label2.ForeColor = System.Drawing.Color.Green;
                    con.connectdb.Close();
                }
                catch (Exception)
                {
                    label2.Text = "Failed to Connect to Mysql Database!";
                    

            }
            
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
