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
    public partial class EmployeesV2 : Form
    {
        public EmployeesV2()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void EmployeesV2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Post' table. You can move, or remove it, as needed.
            this.postTableAdapter.Fill(this.hotelDataSet.Post);
            // TODO: This line of code loads data into the 'hotelDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotelDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);
        }
    }
}
