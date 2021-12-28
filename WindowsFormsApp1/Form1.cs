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

        Visitor visitor = new Visitor();
        Form2 form = new Form2();
        //TicketPrices ticketPrices = new TicketPrices(400, 700, 1050, 1450, 2200,
        //    550, 1000, 1500, 2100, 2700,
        //    380, 670, 1010, 1400, 2100,
        //    370, 660, 1000, 1390, 2090,
        //    360, 650, 990, 1380, 2080,
        //    350, 640, 980, 1370, 2070, 2);
        TicketPrices ticketPrices = new TicketPrices();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                visitor.ticketID = textBoxTicketId.Text;                
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
                int timeSpentInHours = Convert.ToInt32(timeSpent.TotalHours);


                Console.WriteLine(visitor.groupOf.ToString() + visitor.age + timeSpentInHours, isHolidayBool);
                int priceWithoutDiscount = priceCalculation(visitor.groupOf, visitor.age, timeSpentInHours, isHolidayBool);
                visitor.price = priceForHoliday(priceWithoutDiscount);
                Console.WriteLine(visitor.price.ToString());
                saveFileDialog1.ShowDialog();
                string textFilePath = saveFileDialog1.FileName;

                WriteToCsv(textFilePath, visitor.ticketID, visitor.name, visitor.age, visitor.isGroup, visitor.groupOf
                    ,visitor.date, visitor.entryTime, visitor.exitTime, visitor.price, visitor.isHoliday);

                labelTimeSpent.Text = timeSpentInHours.ToString();
                labelAgeDisplay.Text = visitor.age.ToString();
                labelGroupOfDisplay.Text = visitor.groupOf.ToString();
                if(bool.Parse(visitor.isHoliday) == true)
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
            }
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
                    date = data[5],
                    entryTime = data[6],
                    exitTime = data[7],
                    price = int.Parse(data[8]),
                    isHoliday = (data[9])
                };

                return visitor_data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
                        
        }

        public int priceCalculation(int groupOf, int age, int timeSpentHrs, Boolean isHoliday)
        {
            
            //int price = visitor.price;

            // For group of 0
            // Group of 0 and child
            if (groupOf == 0 && age <= 12 && timeSpentHrs == 1)
            {
                visitor.price = ticketPrices.priceChild1Hr;
                return visitor.price;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceChild2Hrs;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceChild3Hrs;
            }
            else if (groupOf == 0 && age <= 12 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceChild2Hrs;
            }
            else if (groupOf == 0 && age <= 12)
            {
                return visitor.price = ticketPrices.priceChildWholeDay;
            }

            // Group of 0 and adult:
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 1)
            {
                return visitor.price = ticketPrices.priceAdult1Hr;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceAdult2Hrs;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceAdult3Hrs;
            }
            else if (groupOf == 0 && age > 12 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceAdult4Hrs;
            }
            else if (groupOf == 0 && age > 12)
            {
                return visitor.price = ticketPrices.priceAdultWholeDay;
            }

            // Group of 5:
            else if (groupOf == 5 && timeSpentHrs == 1)
            {
                return visitor.price = ticketPrices.priceGroup51Hr;
            }
            else if (groupOf == 5 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceGroup52Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceGroup53Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceGroup54Hrs;
            }
            else if (groupOf == 5 && timeSpentHrs >= 5)
            {
                return visitor.price = ticketPrices.priceGroup5WholeDay;
            }

            // Group of 10:
            else if (groupOf == 10 && timeSpentHrs == 1)
            {
                return visitor.price = ticketPrices.priceGroup101Hr;
            }
            else if (groupOf == 10 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceGroup102Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceGroup103Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceGroup104Hrs;
            }
            else if (groupOf == 10 && timeSpentHrs >= 5)
            {
                return visitor.price = ticketPrices.priceGroup10WholeDay;
            }

            // Group of 15:
            else if (groupOf == 15 && timeSpentHrs == 1)
            {
                return visitor.price = ticketPrices.priceGroup151Hr;
            }
            else if (groupOf == 15 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceGroup152Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceGroup153Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceGroup154Hrs;
            }
            else if (groupOf == 15 && timeSpentHrs >= 5)
            {
                return visitor.price = ticketPrices.priceGroup15WholeDay;
            }

            // Group of 20:
            else if (groupOf == 20 && timeSpentHrs == 1)
            {
                return visitor.price = ticketPrices.priceGroup201Hr;
            }
            else if (groupOf == 20 && timeSpentHrs == 2)
            {
                return visitor.price = ticketPrices.priceGroup202Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs == 3)
            {
                return visitor.price = ticketPrices.priceGroup203Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs == 4)
            {
                return visitor.price = ticketPrices.priceGroup204Hrs;
            }
            else if (groupOf == 20 && timeSpentHrs >= 5)
            {
                return visitor.price = ticketPrices.priceGroup20WholeDay;
            }

            //visitor.price = calculateDiscountForHoliday(visitor.price, isHoliday);

            return visitor.price;
        }

        public int priceForHoliday(int price)
        {
            if(bool.Parse(visitor.isHoliday) == true)
            {
                return price -= ((ticketPrices.holidayDiscount/100) * price);
            }
            return price;
        }

        public int calculateDiscountForHoliday(int price, bool isHoliday)
        {
            if (isHoliday)
            {
                return price -= (ticketPrices.holidayDiscount * price);
            }
            else return price;
        }

            public void WriteToCsv(string filePath, string ticketID, string name, int age, string isGroup,
            int groupOf, string date, string entryTime, string exitTime, int price, string isHoliday)
        {
            try
            {
                // true will allow to append the file
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath,true))
                {
                    file.WriteLine(ticketID + "," + name + "," + age + "," + isGroup + "," + groupOf + "," + date + ","
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
            textBoxTicketId.Text = "";
            textBoxName.Text = "";
            textBoxAge.Text = "";
            comboBoxGroupOf.SelectedIndex = 0;
            comboBoxEntryHour.SelectedIndex = 0;
            comboBoxEntryMinute.SelectedIndex = 0;
            comboBoxExitHour.SelectedIndex = 0; 
            comboBoxExitMinute.SelectedIndex = 0;
            checkBoxIsHoliday.Checked = false;
        }
    }
}
