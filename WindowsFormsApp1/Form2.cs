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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        TicketPrices ticketPrices = new TicketPrices();

        private void buttonSave_Click(object sender, EventArgs e)
        {

            ticketPrices.priceChild1Hr = int.Parse(textBoxChild1Hr.Text);
            ticketPrices.priceChild2Hrs = int.Parse(textBoxChild2Hrs.Text);
            ticketPrices.priceChild3Hrs = int.Parse(textBoxChild3Hrs.Text);
            ticketPrices.priceChild4Hrs = int.Parse(textBoxChild4Hrs.Text);
            ticketPrices.priceChildWholeDay = int.Parse(textBoxChildWholeDay.Text);

            ticketPrices.priceAdult1Hr = int.Parse(textBoxAdult1Hr.Text);
            ticketPrices.priceAdult2Hrs = int.Parse(textBoxAdult2Hrs.Text);
            ticketPrices.priceAdult3Hrs = int.Parse(textBoxAdult3Hrs.Text);
            ticketPrices.priceAdult4Hrs = int.Parse(textBoxAdult4Hrs.Text);
            ticketPrices.priceAdultWholeDay = int.Parse(textBoxAdultWholeDay.Text);

            ticketPrices.priceGroup51Hr = int.Parse(textBoxGroup51Hr.Text);
            ticketPrices.priceGroup52Hrs = int.Parse(textBoxGroup52Hrs.Text);
            ticketPrices.priceGroup53Hrs = int.Parse(textBoxGroup53Hrs.Text);
            ticketPrices.priceGroup54Hrs = int.Parse(textBoxGroup54Hrs.Text);
            ticketPrices.priceGroup5WholeDay = int.Parse(textBoxGroup5WholeDay.Text);

            ticketPrices.priceGroup101Hr = int.Parse(textBoxGroup101Hr.Text);
            ticketPrices.priceGroup102Hrs = int.Parse(textBoxGroup102Hrs.Text);
            ticketPrices.priceGroup103Hrs = int.Parse(textBoxGroup103Hrs.Text);
            ticketPrices.priceGroup104Hrs = int.Parse(textBoxGroup104Hrs.Text);
            ticketPrices.priceGroup10WholeDay = int.Parse(textBoxGroup10WholeDay.Text);

            ticketPrices.priceGroup151Hr = int.Parse(textBoxGroup151Hr.Text);
            ticketPrices.priceGroup152Hrs = int.Parse(textBoxGroup152Hrs.Text);
            ticketPrices.priceGroup153Hrs = int.Parse(textBoxGroup153Hrs.Text);
            ticketPrices.priceGroup154Hrs = int.Parse(textBoxGroup154Hrs.Text);
            ticketPrices.priceGroup15WholeDay = int.Parse(textBoxGroup15WholeDay.Text);

            ticketPrices.priceGroup201Hr = int.Parse(textBoxGroup201Hr.Text);
            ticketPrices.priceGroup202Hrs = int.Parse(textBoxGroup202Hrs.Text);
            ticketPrices.priceGroup203Hrs = int.Parse(textBoxGroup203Hrs.Text);
            ticketPrices.priceGroup204Hrs = int.Parse(textBoxGroup204Hrs.Text);
            ticketPrices.priceGroup20WholeDay = int.Parse(textBoxGroup20WholeDay.Text);

            ticketPrices.holidayDiscount = float.Parse(textBoxHolidayDiscount.Text);

            saveFileDialog1.ShowDialog();
            string textFilePath = saveFileDialog1.FileName;
            WriteToCsv(textFilePath,
                ticketPrices.priceChild1Hr.ToString(), ticketPrices.priceChild2Hrs.ToString(), ticketPrices.priceChild3Hrs.ToString(), ticketPrices.priceChild4Hrs.ToString(), ticketPrices.priceChildWholeDay.ToString(),
                ticketPrices.priceAdult1Hr.ToString(), ticketPrices.priceAdult2Hrs.ToString(), ticketPrices.priceAdult3Hrs.ToString(), ticketPrices.priceAdult4Hrs.ToString(), ticketPrices.priceAdultWholeDay.ToString(),
                ticketPrices.priceGroup51Hr.ToString(), ticketPrices.priceGroup52Hrs.ToString(), ticketPrices.priceGroup53Hrs.ToString(), ticketPrices.priceGroup54Hrs.ToString(), ticketPrices.priceGroup5WholeDay.ToString(),
                ticketPrices.priceGroup101Hr.ToString(), ticketPrices.priceGroup102Hrs.ToString(), ticketPrices.priceGroup103Hrs.ToString(), ticketPrices.priceGroup104Hrs.ToString(), ticketPrices.priceGroup10WholeDay.ToString(),
                ticketPrices.priceGroup151Hr.ToString(), ticketPrices.priceGroup152Hrs.ToString(), ticketPrices.priceGroup153Hrs.ToString(), ticketPrices.priceGroup154Hrs.ToString(), ticketPrices.priceGroup15WholeDay.ToString(),
                ticketPrices.priceGroup201Hr.ToString(), ticketPrices.priceGroup202Hrs.ToString(), ticketPrices.priceGroup203Hrs.ToString(), ticketPrices.priceGroup204Hrs.ToString(), ticketPrices.priceGroup20WholeDay.ToString()
                , ticketPrices.holidayDiscount.ToString()
                );
        }

        public void WriteToCsv(string filePath,
            string priceChild1Hr, string priceChild2Hrs, string priceChild3Hrs, string priceChild4Hrs, string priceChildWholeDay,
            string priceAdult1Hr, string priceAdult2Hrs, string priceAdult3Hrs, string priceAdult4Hrs, string priceAdultWholeDay,
            string priceGroup51Hr, string priceGroup52Hrs, string priceGroup53Hrs, string priceGroup54Hrs, string priceGroup5WholeDay,
            string priceGroup101Hr, string priceGroup102Hrs, string priceGroup103Hrs, string priceGroup104Hrs, string priceGroup10WholeDay,
            string priceGroup151Hr, string priceGroup152Hrs, string priceGroup153Hrs, string priceGroup154Hrs, string priceGroup15WholeDay,
            string priceGroup201Hr, string priceGroup202Hrs, string priceGroup203Hrs, string priceGroup204Hrs, string priceGroup20WholeDay,
            string holidayDiscount)
        {
            try
            {
                // true will allow to append the file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, false))
                {
                    file.WriteLine("Ticket Rate,1Hr,2Hrs,3Hrs,4Hrs,Whole Day");
                    file.WriteLine("Child (<12)," + priceChild1Hr + "," + priceChild2Hrs + "," + priceChild3Hrs + "," + priceChild4Hrs + "," + priceChildWholeDay);
                    file.WriteLine("Adult (>12)," + priceAdult1Hr + "," + priceAdult2Hrs + "," + priceAdult3Hrs + "," + priceAdult4Hrs + "," + priceAdultWholeDay);
                    file.WriteLine("Group 5," + priceGroup51Hr + "," + priceGroup52Hrs + "," + priceGroup53Hrs + "," + priceGroup54Hrs + "," + priceGroup5WholeDay);
                    file.WriteLine("Group 10," + priceGroup101Hr + "," + priceGroup102Hrs + "," + priceGroup103Hrs + "," + priceGroup104Hrs + "," + priceGroup10WholeDay);
                    file.WriteLine("Group 15," + priceGroup151Hr + "," + priceGroup152Hrs + "," + priceGroup153Hrs + "," + priceGroup154Hrs + "," + priceGroup15WholeDay);
                    file.WriteLine("Group 20," + priceGroup201Hr + "," + priceGroup202Hrs + "," + priceGroup203Hrs + "," + priceGroup204Hrs + "," + priceGroup20WholeDay);
                    file.WriteLine("Holiday Discount," + holidayDiscount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured in entering data, Please Check", "Try Again",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ImportFromCsv(string filePath)
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                string[] line1Data = lines[0].Split(',');
                textBoxChild1Hr.Text = line1Data[0].ToString();
                textBoxChild2Hrs.Text = line1Data[1].ToString();
                textBoxChild3Hrs.Text= line1Data[2].ToString();
                textBoxChild4Hrs.Text = line1Data[3].ToString();
                textBoxChildWholeDay.Text = line1Data[4].ToString(); 

                string[] line2Data = lines[1].Split(',');
                textBoxAdult1Hr.Text= line2Data[0].ToString();
                textBoxAdult2Hrs.Text = line2Data[1].ToString();
                textBoxAdult3Hrs.Text = line2Data[2].ToString();
                textBoxAdult4Hrs.Text = line2Data[3].ToString(); 
                textBoxAdultWholeDay.Text = line2Data[4].ToString();

                string[] line3Data = lines[2].Split(',');
                textBoxGroup51Hr.Text = line3Data[0].ToString();
                textBoxGroup52Hrs.Text = line3Data[1].ToString();
                textBoxGroup53Hrs.Text = line3Data[2].ToString();
                textBoxGroup54Hrs.Text = line3Data[3].ToString();
                textBoxGroup5WholeDay.Text = line3Data[4].ToString();

                string[] line4Data = lines[3].Split(',');
                textBoxGroup101Hr.Text = line4Data[0].ToString();
                textBoxGroup102Hrs.Text =line4Data[1].ToString();
                textBoxGroup103Hrs.Text = line4Data[2].ToString();
                textBoxGroup104Hrs.Text= line4Data[3].ToString();
                textBoxGroup10WholeDay.Text= line4Data[4].ToString();

                string[] line5Data = lines[4].Split(',');
                textBoxGroup151Hr.Text = line5Data[0].ToString();
                textBoxGroup152Hrs.Text = line5Data[1].ToString();
                textBoxGroup153Hrs.Text = line5Data[2].ToString();
                textBoxGroup154Hrs.Text = line5Data[3].ToString();
                textBoxGroup15WholeDay.Text = line5Data[4].ToString();

                string[] line6Data = lines[5].Split(',');
                textBoxGroup201Hr.Text = line6Data[0].ToString();
                textBoxGroup202Hrs.Text = line6Data[1].ToString();
                textBoxGroup203Hrs.Text = line6Data[2].ToString();
                textBoxGroup204Hrs.Text = line6Data[3].ToString();
                textBoxGroup20WholeDay.Text = line6Data[4].ToString();
            }
            catch (Exception ex)
            {

            }
        }
            

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string textFilePath = openFileDialog1.FileName;
            ImportFromCsv(textFilePath);
        }
    }
}
       


        

