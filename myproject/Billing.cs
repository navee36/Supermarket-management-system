using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Private sub DisplayItem()
                Con.Open()
                Dim query = "select * from ItemTbl"
                Dim cmd = New SqlCommand(query, Con)
                Dim adapter As SqlDataAdapter
                adapter = new SqlDataAdapter(cmd)
                Dim builder As New SqlCommandBuilder(adapter)
                Dim ds As Dataset
                ds = New Dataset
                adapter.Fill(ds)
                ItemDGV.DataSource = ds.Tables(0)

                Con.Close()
            End sub
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
