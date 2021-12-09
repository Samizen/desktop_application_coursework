using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonVisitorEntry_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void buttonTicketRate_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonViewReport_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
