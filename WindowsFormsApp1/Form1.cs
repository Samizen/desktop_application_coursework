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
            visitor.name = textBoxName.Text;
            visitor.age = int.Parse(textBoxAge.Text);
            visitor.isGroup = checkboxIsGroup.Checked;
            if (comboBoxGroupOf.SelectedItem != null)
            {
                visitor.groupOf = int.Parse(comboBoxGroupOf.SelectedItem.ToString());
            }
            visitor.entryTime = DateTime.Now;
            visitor.exitTime = dateTimePickerExitTime.Value;
        }

    }
}
