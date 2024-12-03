using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.selectedIndex = -1 Or PriceTb.Text = "" Th
                MsgBox("missing information")
                Else
                    Try
                    Con.Open()
                Dim Query  "Update ItemTbl set ItName '"& ItnameTb.Text & "',ItQty "& QtyTb.Text &", ItPrice "& PriceTB.Text &",ItCat '"& CatCb.selectedItem.ToString() &"' where ItId "& Key &""
                Dim cmd As sqlCommand
                cmd = new sqlCommand(Query, Con)
                cmd.ExecuteNonQuery();
            MsgBox("Item updated successfully")
                Con.Close()
                DisplayItem()
                Clear()
                Catch ex As Exception
                End Try
                End If

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if key = 0 Then
                MsgBox("select Item to delete information")
                Else
                    Try
                    Con.Open()
                Dim Query = "delete from ItemTbl where ItId= "& Key & ""
                Dim cmd As sqlCommand
                cmd = new sqlCommand(Query, Con)
                cmd.ExecuteNonQuery();
            MsgBox("Item delete successfully")
                Con.Close()
                DisplayItem()
                Clear()
                Catch ex As Exception
                End Try
                End If

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.selectedIndex = -1 Or PriceTb.Text = "" Th
                MsgBox("missing information")
                Else
                    Try
                    Con.Open()
                Dim Query = "insert into ItemTbl values('" & ItnameTb.Text & "', " & QtyTb.Text & ","& PriceTB.Text &",'"& CatCb.SelectedItem.ToString() &"')"
                Dim cmd As sqlCommand
                cmd = new sqlCommand(Query,Con)
                cmd.ExecuteNonQuery();
                MsgBox("Item saved successfully")
                Con.Close()
                DisplayItem()
                Clear()
                Catch ex As Exception
                End Try
                End If
                End Sub
                End Class




        }

        private sub Clear()
            ItnameTb.Text = ""
            QtyTb.Text = ""
            CatCb.selectedIndex = 0
            End sub
        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            Private sub DisplayItem()
                Con.Open()
                Dim query = "select * from ItemTbl"
                Dim cmd =  New SqlCommand(query, Con)
                Dim adapter As SqlDataAdapter
                adapter = new SqlDataAdapter(cmd)
                Dim builder As New SqlCommandBuilder(adapter)
                Dim ds As Dataset
                ds = New Dataset
                adapter.Fill(ds)
                ItemDGV.DataSource =ds.Tables(0)

                Con.Close()
            End sub
                Dim key = 0
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
                ItnameTb.Text = row.Cells(1).value.ToString
              QtyTb.Text = row.Cells(1).value.ToString
                PriceTb.Text = row.cells(1).value.ToString()
                CatCb.SelectedItem = row.cells(3).Value.ToString()
                If ItnameTb.Text = ""Then
                KEY = 0
                Else
                key = Convert.ToInt32(ItnameTb.Text = row.Cells(0).value.ToString)
                End If

                End sub
                End Class

                }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DisplayItem()

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
