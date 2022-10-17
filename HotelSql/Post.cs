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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void postBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Post_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Post' table. You can move, or remove it, as needed.
            this.postTableAdapter.Fill(this.hotelDataSet.Post);

        }
    }
}
