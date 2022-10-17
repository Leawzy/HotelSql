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
    public partial class ClientV2 : Form
    {
        public ClientV2()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void ClientV2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);
        }
    }
}
