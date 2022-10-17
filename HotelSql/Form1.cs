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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients frm = new Clients();
            frm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employees frm = new Employees();
            frm.Show(this); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Services services = new Services(); 
            services.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Post frm = new Post();
            frm.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rooms frm = new Rooms();
            frm.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClientV2 clientV2 = new ClientV2();
            clientV2.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmployeesV2 employeesV2 = new EmployeesV2();
            employeesV2.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show(this);
        }
    }
}
