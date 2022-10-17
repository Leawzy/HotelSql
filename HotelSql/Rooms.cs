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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDataSet.Room);

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Клиенты_Click(object sender, EventArgs e)
        {

        }
    }
}
