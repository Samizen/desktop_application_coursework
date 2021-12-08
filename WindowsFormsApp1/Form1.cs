using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            visitor.entryTime = DateTime.Now.ToString("hh:mm tt");
            visitor.exitTime = DateTime.Now.ToString("hh:mm tt");

            saveFileDialog1.ShowDialog();
            string textFilePath = saveFileDialog1.FileName;

            WriteToCsv(textFilePath, visitor.ticketID, visitor.name, visitor.age, visitor.isGroup, visitor.groupOf
                , visitor.entryTime, visitor.exitTime, visitor.price, visitor.isHoliday);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string textFilePath = openFileDialog1.FileName;
            ReadCSV(textFilePath);
        }

        DataTable dt = new DataTable();

        private void ReadCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                        dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    dataGridVisitor.DataSource = dt;
                }
            }
        }

        public void WriteToCsv(string filePath, string ticketID, string name, int age, Boolean isGroup,
            int groupOf, string entryTime, string exitTime, int price, Boolean isHoliday)
        {
            try
            {
                // true will allow to append the file
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath,true))
                {
                    file.WriteLine(ticketID + "," + name + "," + age + "," + isGroup + "," + groupOf + "," 
                        + entryTime + "," + exitTime + "," + price + "," + isHoliday);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured in entering data, Please Check", "Try Again",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
