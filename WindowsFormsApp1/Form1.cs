using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        Visitor visitor = new Visitor();
        TicketPrices ticketPrices = new TicketPrices();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int timeSpentInHours;
            try
            {
                visitor.ticketID = "T" + DateTime.Now.Ticks.ToString().Substring(0, 10);
                //visitor.ticketID = textBoxTicketId.Text;                
                visitor.name = textBoxName.Text;
                visitor.age = int.Parse(textBoxAge.Text);
                visitor.date = datePicker.Value.ToString("MM/dd/yyyy");
                visitor.groupOf = int.Parse(comboBoxGroupOf.SelectedItem.ToString());
                visitor.entryTime = comboBoxEntryHour.SelectedItem.ToString() + ":"
                    + comboBoxEntryMinute.SelectedItem.ToString();
                visitor.exitTime = comboBoxExitHour.SelectedItem.ToString() + ":"
                    + comboBoxExitMinute.SelectedItem.ToString();
                Boolean isHolidayBool = checkBoxIsHoliday.Checked;
                visitor.isHoliday = checkBoxIsHoliday.Checked.ToString();

                TimeSpan timeSpent = Convert.ToDateTime(visitor.exitTime) - Convert.ToDateTime(visitor.entryTime);
                timeSpentInHours = Convert.ToInt32(timeSpent.TotalHours);


                Console.WriteLine(visitor.groupOf.ToString() + visitor.age + timeSpentInHours, isHolidayBool);
                int priceWithoutDiscount = priceCalculation(visitor.groupOf, visitor.age, timeSpentInHours);
                visitor.price = calculateDiscountForHoliday(priceWithoutDiscount, bool.Parse(visitor.isHoliday));
                Console.WriteLine(visitor.price.ToString());
                saveFileDialog1.ShowDialog();
                string textFilePath = saveFileDialog1.FileName;

                WriteToCsv(textFilePath, visitor.ticketID, visitor.name, visitor.age, visitor.groupOf
                    , visitor.date, visitor.entryTime, visitor.exitTime, visitor.price, visitor.isHoliday);

                labelTicketIdDisplay.Text = visitor.ticketID.ToString();
                labelTimeSpent.Text = timeSpentInHours.ToString();
                labelAgeDisplay.Text = visitor.age.ToString();
                labelGroupOfDisplay.Text = visitor.groupOf.ToString();
                if (bool.Parse(visitor.isHoliday) == true)
                {
                    checkBoxisHolidayDisplay.Checked = true;
                }
                labelTotalPrice.Text = visitor.price.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please check your input for Name, Age, Date, Entry Time and Exit Time.", ex.ToString());
                if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Cannot input empty Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (String.IsNullOrEmpty(textBoxAge.Text))
                {
                    MessageBox.Show("Cannot input empty Age", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int a;
                if (!int.TryParse(textBoxAge.Text, out a))
                {
                    MessageBox.Show("Input age in number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (int.Parse(comboBoxEntryHour.Text) > int.Parse(comboBoxExitHour.Text))
                {
                    MessageBox.Show("Entry time greater than exit time. Customer must at least spend an hour.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string textFilePath = openFileDialog1.FileName;
            dataGridVisitor.DataSource = ReadCSV(textFilePath);
            dataGridVisitor.ReadOnly = false;
            dataGridVisitor.Columns[0].ReadOnly = true;
            dataGridVisitor.Columns[1].ReadOnly = true;
            dataGridVisitor.Columns[2].ReadOnly = true;
            dataGridVisitor.Columns[3].ReadOnly = true;
            dataGridVisitor.Columns[4].ReadOnly = true;
            dataGridVisitor.Columns[5].ReadOnly = true;
            dataGridVisitor.Columns[6].ReadOnly = false;
            dataGridVisitor.Columns[7].ReadOnly = true;
            dataGridVisitor.Columns[8].ReadOnly = true;
        }

        //DataTable dt = new DataTable();

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
                                       groupOf = int.Parse(data[3]),
                                       date = data[4],
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

        public int priceCalculation(int groupOf, int age, int timeSpentHrs)
        {
            // For group of 0
            // Group of 0 and child
            if (groupOf == 0 && age <= 12 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceChild1Hr;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceChild2Hrs;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceChild3Hrs;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceChild2Hrs;
            }
            else if (groupOf == 0 && age <= 12)
            {
                visitor.price = ticketPrices.priceChildWholeDay;
            }

            // Group of 0 and adult:
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceAdult1Hr;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceAdult2Hrs;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceAdult3Hrs;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceAdult4Hrs;
            }
            else if (groupOf == 0 && age > 12)
            {
                visitor.price = ticketPrices.priceAdultWholeDay;
            }

            // Group of 5:
            else if (groupOf == 5 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceGroup51Hr;
            }
            else if (groupOf == 5 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceGroup52Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceGroup53Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceGroup54Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs >= 5)
            {
                visitor.price = ticketPrices.priceGroup5WholeDay;
            }

            // Group of 10:
            else if (groupOf == 10 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceGroup101Hr;
            }
            else if (groupOf == 10 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceGroup102Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceGroup103Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceGroup104Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs >= 5)
            {
                visitor.price = ticketPrices.priceGroup10WholeDay;
            }

            // Group of 15:
            else if (groupOf == 15 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceGroup151Hr;
            }
            else if (groupOf == 15 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceGroup152Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceGroup153Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceGroup154Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs >= 5)
            {
                visitor.price = ticketPrices.priceGroup15WholeDay;
            }

            // Group of 20:
            else if (groupOf == 20 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceGroup201Hr;
            }
            else if (groupOf == 20 && timeSpentHrs == 2)
            {
                visitor.price = ticketPrices.priceGroup202Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs == 3)
            {
                visitor.price = ticketPrices.priceGroup203Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs == 4)
            {
                visitor.price = ticketPrices.priceGroup204Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs >= 5)
            {
                visitor.price = ticketPrices.priceGroup20WholeDay;
            }


            return visitor.price;
        }

        public int calculateDiscountForHoliday(int price, bool isHoliday)
        {
            if (isHoliday)
            {
                return price -= ((ticketPrices.holidayDiscount / 100) * price);
            }
            else return price;
        }

        public void WriteToCsv(string filePath, string ticketID, string name, int age,
            int groupOf, string date, string entryTime, string exitTime, int price, string isHoliday)
        {
            try
            {
                // true will allow to append the file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, true))
                {
                    file.WriteLine(ticketID + "," + name + "," + age + "," + groupOf + "," + date + ","
                        + entryTime + "," + exitTime + "," + price + "," + isHoliday);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured in entering data, Please Check", "Try Again",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxAge.Text = "";
            comboBoxGroupOf.SelectedIndex = 0;
            comboBoxEntryHour.SelectedIndex = 0;
            comboBoxEntryMinute.SelectedIndex = 0;
            comboBoxExitHour.SelectedIndex = 0;
            comboBoxExitMinute.SelectedIndex = 0;
            checkBoxIsHoliday.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridVisitor.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridVisitor.Columns.Count;
                            //string columnNames = "";
                            string[] outputCsv = new string[dataGridVisitor.Rows.Count + 1];
                            //for (int i = 0; i < columnCount; i++)
                            //{
                            //    columnNames += dataGridVisitor.Columns[i].HeaderText.ToString() + ",";
                            //}
                            //outputCsv[0] += columnNames;
                            Regex rgx = new System.Text.RegularExpressions.Regex(@"^(?: 0?[0 - 9] | 1[0 - 9] | 2[0 - 3]):[0 - 5][0 - 9]$");

                            for (int i = 1; (i - 1) < dataGridVisitor.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i - 1] += dataGridVisitor.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    //String validationExitTime = dataGridVisitor.Rows[i - 1].Cells[6].Value.ToString();
                                    //if (!rgx.IsMatch(validationExitTime))
                                    //{
                                    //    MessageBox.Show("Error : Exit Time in incorrect format.");
                                    //    break;
                                    //}
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            dataGridVisitor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridVisitor.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridVisitor.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                //if (!valueResult)
                //{
                //    MessageBox.Show("Unable to find " + textBoxSearch.Text, "Not Found");
                //    return;
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            //BindingSource bs = new BindingSource();
            //bs.DataSource = dataGridVisitor.DataSource;
            //bs.Filter = "name like '%" + textBoxSearch.Text + "%'";
            //dataGridVisitor.DataSource = bs;

        }
    }
}





        
