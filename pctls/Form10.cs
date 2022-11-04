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
    public partial class Form10 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form10()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                String querry = "UPDATE [Produit] SET  nom_p = '" + textBox2.Text + "' ,qte = '" + textBox3.Text + "' ,couleur = '" + textBox4.Text + "' ,prix = '" + textBox5.Text + "'  WHERE id_p = '" + textBox1.Text + "' ";
                //MessageBox.Show(querry);
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produit Edit Successul");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                String querry = "delete from [produit] WHERE id_p='" + textBox1.Text + "'";
                //MessageBox.Show(querry);
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produit deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
        }
    }

}

