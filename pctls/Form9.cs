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
    public partial class Form9 : Form
    {
        String ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lenovo\Documents\pctools.accdb;
Persist Security Info=False;";
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource src;
        DataView v = new DataView();
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection();
            con.ConnectionString = ConnectionString;
            ds = new DataSet();
            tables = ds.Tables;
            da = new OleDbDataAdapter("Select * from [produit]", con);
            da.Fill(ds, "user");
            DataView v = new DataView(tables[0]);
            src = new BindingSource();
            src.DataSource = v;
            dataGridView1.DataSource = v;
        }
    }
}
