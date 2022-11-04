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
    public partial class Form3 : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public Form3()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
             {
                if (textBox1.Text.Length == 0 || textBox7.Text.Length == 0)
                {
                    MessageBox.Show("Remplir le champs id user et password");
                }

                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                
                cmd.CommandText = "insert into [user] (id_u,id_a,nom_u,prenom_u,tel_u,email_u,pwd_u) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("user saved");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            con.Close();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
