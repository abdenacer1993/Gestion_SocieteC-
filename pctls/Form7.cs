using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pctls
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajout_u();
        }

        private void ajout_u()
        {
            Form8 f8 = new Form8();
            TabPage tb = new TabPage(); //{ Text = f8.Text};
            tb.Text = f8.Text;
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f8.TopLevel = false;
            f8.Parent = tb;
            f8.Show();
            f8.Dock = DockStyle.Fill;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            affiche_u();
        }

        private void affiche_u()
        {
            Form9 f9 = new Form9();
            TabPage tb = new TabPage { Text = f9.Text };
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f9.TopLevel = false;
            f9.Parent = tb;
            f9.Show();
            f9.Dock = DockStyle.Fill;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            modif_supp_u();
        }

        private void modif_supp_u()
        {
            Form10 f10 = new Form10();
            TabPage tb = new TabPage { Text = f10.Text };
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f10.TopLevel = false;
            f10.Parent = tb;
            f10.Show();
            f10.Dock = DockStyle.Fill;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
