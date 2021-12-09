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
            visitor.isGroup = checkboxIsGroup.Checked.ToString();
            visitor.groupOf = int.Parse(comboBoxGroupOf.SelectedItem.ToString());            
            visitor.entryTime = DateTime.Now.ToString("hh:mm tt");
            visitor.exitTime = DateTime.Now.ToString("hh:mm tt");
            visitor.isHoliday = checkBoxIsHoliday.Checked.ToString();

            saveFileDialog1.ShowDialog();
            string textFilePath = saveFileDialog1.FileName;

            WriteToCsv(textFilePath, visitor.ticketID, visitor.name, visitor.age, visitor.isGroup, visitor.groupOf
                , visitor.entryTime, visitor.exitTime, visitor.price, visitor.isHoliday);
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string textFilePath = openFileDialog1.FileName;
            dataGridVisitor.DataSource = ReadCSV(textFilePath);
        }

        DataTable dt = new DataTable();

        List<Visitor> ReadCSV(string filePath)
        {
            
            try
            {
                var visitor_data = from l in File.ReadAllLines(filePath)
                let data = l.Split(',')
                select new Visitor
                {
                    ticketID = data[0],
                    name = data[1],
                    age = int.Parse(data[2]),
                    isGroup = (data[3]),
                    groupOf = int.Parse(data[4]),
                    entryTime = data[5],
                    exitTime = data[6],
                    price = int.Parse(data[7]),
                    isHoliday = (data[8])
                };

                return visitor_data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
                        
        }

        public void WriteToCsv(string filePath, string ticketID, string name, int age, string isGroup,
            int groupOf, string entryTime, string exitTime, int price, string isHoliday)
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
