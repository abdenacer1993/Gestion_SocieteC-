using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pctls
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from admin where id_a='" + textBox1.Text + "' and pwd_a='" + textBox2.Text + "'";
            OleDbDataReader rd = cmd.ExecuteReader();
            

            int count = 0;
            
            while (rd.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {

                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }
            
            if (count != 1 )
            {
                MessageBox.Show("Id or Password invalid");
            }
            con.Close();
            
        }

        private void connectUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

