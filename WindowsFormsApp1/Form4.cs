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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

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

        private void buttonChooseDate_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string textFilePath = openFileDialog2.FileName;            
            List<Visitor> visitors = ReadCSV(textFilePath);
            string selectedDate = dateTimePickerSelection.Value.ToString("MM/dd/yyyy");
            Console.WriteLine(selectedDate);
            List<Visitor> visitorsOrderedByDate = new List<Visitor>();
            

            // Sort the list by date:
            visitorsOrderedByDate = visitors.OrderBy(x => x.date).ToList();

            // Group the list by date - count child(age<12) and adult(age>=12) 
                    // Filter data for only the selected date:
            List<Visitor> visitorsForEachDate = visitorsOrderedByDate.Where(x => x.date == selectedDate).ToList();
            // Count no of different categories:
            int NoOfAdult = visitorsForEachDate.Count(x => x.age > 12);
            int NoOfChild = visitorsForEachDate.Count(x => x.age <= 12);
            int NoOfGroup5 = visitorsForEachDate.Count(x => x.groupOf == 5);
            int NoOfGroup10 = visitorsForEachDate.Count(x => x.groupOf == 10);
            int NoOfGroup15 = visitorsForEachDate.Count(x => x.groupOf == 15);
            int NoOfGroup20 = visitorsForEachDate.Count(x => x.groupOf == 20);
            int NoOfGroup0 = visitorsForEachDate.Count(x => x.groupOf == 0);
            labelNoChild.Text = NoOfChild.ToString();
            labelAdultNo.Text = NoOfAdult.ToString();
            labelNoGroup5.Text = NoOfGroup5.ToString();
            labelNoGroup10.Text = NoOfGroup10.ToString();
            labelNoGroup15.Text = NoOfGroup15.ToString();
            labelNoGroup20.Text = NoOfGroup20.ToString();

            foreach (var visitor in visitorsForEachDate)
            {
                Console.WriteLine(visitor);
            }
        }
    }
}
