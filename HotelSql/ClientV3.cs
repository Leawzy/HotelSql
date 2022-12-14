using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSql
{
    public partial class ClientV3 : Form
    {
        public ClientV3()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void ClientV3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDataSet.Room);
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn10;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn11;
                    break;
            }
            if (radioButton1.Checked)
            {
               clientsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                clientsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = "CheckInDate=#" + comboBox1.Text + "#";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < clientsDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < clientsDataGridView.ColumnCount - 1; j++)
                {
                    clientsDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    clientsDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < clientsDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < clientsDataGridView.ColumnCount; j++)
                {
                    var value = clientsDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            clientsDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            clientsDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }    
                }
            }
        }
    }
}
