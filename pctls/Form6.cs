using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pctls
{
    public partial class Form6 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form6()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from [user] where id_u='" + textBox1.Text + "' and pwd_u='" + textBox2.Text + "'";
            OleDbDataReader rd = cmd.ExecuteReader();


            int count = 0;

            while (rd.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {

                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();

            }

            //if (count != 0)
            else{
                MessageBox.Show("Id or Password invalid");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
