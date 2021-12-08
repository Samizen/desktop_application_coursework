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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Visitor visitor = new Visitor();

        private void btnSave_Click(object sender, EventArgs e)
        {
            visitor.ticketID = textBoxTicketId.Text;
            visitor.ticketName = textBoxName.Text;
            visitor.groupNoOfPeople = comboBoxGroup.SelectedIndex;
            visitor.entryTime = dateTimePickerEntryTime.Value;
            visitor.exitTime = dateTimePickerExitTime.Value;
            visitor.age = int.Parse(textBoxAge.Text);
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
