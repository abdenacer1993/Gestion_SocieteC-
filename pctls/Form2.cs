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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajout_u();
        }

        private void ajout_u()
        {
            Form3 f3 = new Form3();
            TabPage tb = new TabPage(); //{ Text = f3.Text};
            tb.Text = f3.Text;
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f3.TopLevel = false;
            f3.Parent = tb;
            f3.Show();
            f3.Dock = DockStyle.Fill;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            affiche_u();
        }

        private void affiche_u()
        {
            Form4 f4 = new Form4();
            TabPage tb = new TabPage { Text = f4.Text };
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f4.TopLevel = false;
            f4.Parent = tb;
            f4.Show();
            f4.Dock = DockStyle.Fill;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            modif_supp_u();
        }

        private void modif_supp_u()
        {
            Form5 f5 = new Form5();
            TabPage tb = new TabPage { Text = f5.Text };
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            //tabControl1.Refresh();
            f5.TopLevel = false;
            f5.Parent = tb;
            f5.Show();
            f5.Dock = DockStyle.Fill;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
