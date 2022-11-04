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
    public partial class Form5 : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public Form5()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                String querry = "UPDATE [user] SET  id_a = '" + textBox2.Text + "' ,nom_u = '" + textBox3.Text + "' ,prenom_u = '" + textBox4.Text + "' ,tel_u = '" + textBox5.Text + "' ,email_u = '" + textBox6.Text + "' ,pwd_u = '" + textBox7.Text + "' WHERE id_u = '" + textBox1.Text + "' ";
                MessageBox.Show(querry);
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();

                MessageBox.Show("User Edit Successul");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                String querry = "delete from [user] WHERE id_u='" + textBox1.Text + "'";
                //MessageBox.Show(querry);
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();

                MessageBox.Show("User deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
        }
    }
}
