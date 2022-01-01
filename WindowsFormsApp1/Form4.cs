using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime inputDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            var d = inputDate;

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            int currentWeekNo = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            Console.WriteLine(currentWeekNo);
            openFileDialog2.ShowDialog();
            string textFilePath = openFileDialog2.FileName;
            List<Visitor> visitors = ReadCSV(textFilePath);
            List<Visitor> visitorsThisWeek = new List<Visitor>();

            foreach (var visitor in visitors)
            {
                int weekNo = myCal.GetWeekOfYear(Convert.ToDateTime(visitor.date), myCWR, myFirstDOW);
                Console.WriteLine(weekNo);
                if (weekNo == currentWeekNo) { visitorsThisWeek.Add(visitor); }
            }

            int noOfVisitorsSunday = 0;
            int earningSunday = 0;
            int noOfVisitorsMonday = 0;
            int earningMonday = 0;
            int noOfVisitorsTuesday = 0;
            int earningTuesday = 0;
            int noOfVisitorsWednesday = 0;
            int earningWednesday = 0;
            int noOfVisitorsThursday = 0;
            int earningThursday = 0;
            int noOfVisitorsFriday = 0;
            int earningFriday = 0;
            int noOfVisitorsSaturday = 0;
            int earningSaturday = 0;

            foreach (var visitor in visitorsThisWeek)
            {
                string day = Convert.ToDateTime(visitor.date).ToString("dddd");
                Console.WriteLine(visitor.name + " - " + day);

                // Counting no. of visitors and earning for each day:
                if (day.ToLower() == "sunday")
                {
                    noOfVisitorsSunday++;
                    earningSunday += visitor.price;
                }
                if (day.ToLower() == "monday")
                {
                    noOfVisitorsMonday++;
                    earningMonday += visitor.price;
                }
                if (day.ToLower() == "tuesday")
                {
                    noOfVisitorsTuesday++;
                    earningTuesday += visitor.price;
                }
                if (day.ToLower() == "wednesday")
                {
                    noOfVisitorsWednesday++;
                    earningWednesday += visitor.price;
                }
                if (day.ToLower() == "thursday")
                {
                    noOfVisitorsThursday++;
                    earningThursday += visitor.price;
                }
                if (day.ToLower() == "friday")
                {
                    noOfVisitorsFriday++;
                    earningFriday += visitor.price;
                }
                if (day.ToLower() == "saturday")
                {
                    noOfVisitorsSaturday++;
                    earningSaturday += visitor.price;
                }


                string textFilePath1 = "F:\\Application_CW\\application_cw-main\\WindowsFormsApp1\\bin\\Debug\\weekly_report.csv";
                WriteToCsv(textFilePath1, noOfVisitorsSunday, earningSunday, noOfVisitorsMonday, earningMonday, noOfVisitorsTuesday, earningTuesday,
                    noOfVisitorsWednesday, earningWednesday, noOfVisitorsThursday, earningThursday, noOfVisitorsFriday, earningFriday,
                    noOfVisitorsSaturday, earningSaturday);
            }

            MessageBox.Show("Successfully Generated!");
            dataGridWeeklyReport.DataSource = ShowDatagridCSV("F:\\Application_CW\\application_cw-main\\WindowsFormsApp1\\bin\\Debug\\weekly_report.csv");
            ShowChart(dataGridWeeklyReport);
        }
        public void WriteToCsv(string filePath, int noOfVisitorsSunday, int earningSunday,
            int noOfVisitorsMonday, int earningMonday, int noOfVisitorsTuesday, int earningTuesday,
            int noOfVisitorsWednesday, int earningWednesday, int noOfVisitorsThursday, int earningThursday,
            int noOfVisitorsFriday, int earningFriday, int noOfVisitorsSaturday, int earningSaturday)
        {
            try
            {
                // true will allow to append the file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, false))
                {
                    file.WriteLine("Sunday," + noOfVisitorsSunday + "," + earningSunday + '\n' +
                        "Monday," + noOfVisitorsMonday + "," + earningMonday + '\n' +
                        "Tuesday," + noOfVisitorsTuesday + "," + earningTuesday + '\n' +
                        "Wednesday," + noOfVisitorsWednesday + "," + earningWednesday + '\n' +
                        "Thursday," + noOfVisitorsThursday + "," + earningThursday + '\n' +
                        "Friday," + noOfVisitorsFriday + "," + earningFriday + '\n' +
                        "Saturday," + noOfVisitorsSaturday + "," + earningSaturday);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error Occured in entering data, Please Check", "Try Again",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<WeeklyReport> ShowDatagridCSV(string filePath)
        {
            try
            {
                var report_data = from l in File.ReadAllLines(filePath)
                                  let data = l.Split(',')
                                  select new WeeklyReport
                                  {
                                      day = data[0],
                                      noOfVisitors = int.Parse(data[1]),
                                      totalEarning = int.Parse(data[2])
                                  };
                return report_data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void ShowChart(DataGridView dgv)
        {
            List<WeeklyReport> rows = new List<WeeklyReport>();
            foreach (DataGridViewRow dr in dataGridWeeklyReport.Rows)
            {
                //Creating object of my list of type WeeklyReport
                WeeklyReport pl = new WeeklyReport();
                pl.day = dr.Cells[0].Value.ToString();
                pl.noOfVisitors = (int)dr.Cells[1].Value;
                pl.totalEarning = (int)dr.Cells[2].Value;

                //Adding pl to List<WeeklyReport> rows  
                rows.Add(pl);
            }


            // Generate Chart for Number of People
            Series S1 = new Series("Number of People");
            // S1.ChartType = SeriesChartType.Bar;
            chartNoOfVisitors.Series.Add(S1);
            S1.Color = System.Drawing.Color.Red;
            for (int i = 0; i < rows.Count; i++)
            {
                this.chartNoOfVisitors.Series[S1.Name].Points.AddXY(rows[i].day, rows[i].noOfVisitors);
            }

            // Generate Chart for Total Earning 
            Series S = new Series("Total Earning");
            // S.ChartType = SeriesChartType.Bar;
            chartTotalEarning.Series.Add(S);
            for (int i = 0; i < rows.Count; i++)
            {
                this.chartTotalEarning.Series[S.Name].Points.AddXY(rows[i].day, rows[i].totalEarning);
            }
        }

        private void buttonSelectSort_Click(object sender, EventArgs e)
        {
            List<WeeklyReport> rows = ReadFromDataGrid();
            List<WeeklyReport> temp = new List<WeeklyReport>();
            string selection = comboBoxSortCriteria.Text;
            bool flag = true;
            if (selection == "Number of Visitors")
            {
                List<WeeklyReport> sortNoOfPeople = sortVisitor(rows);
                string filepath = "F:\\Application_CW\\application_cw-main\\WindowsFormsApp1\\bin\\Debug\\weekly_report_sorted.csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, false))
                {
                    for(int i = 0; i < sortNoOfPeople.Count; i++)
                    {
                        file.WriteLine(sortNoOfPeople[i].day + ',' + sortNoOfPeople[i].noOfVisitors + ',' + sortNoOfPeople[i].totalEarning);
                    }                    
                }
                dataGridWeeklyReport.DataSource = ShowDatagridCSV(filepath);
            } 
            else if (selection == "Total Earnings")
            {
                List<WeeklyReport> sortTotalEarning = sortEarning(rows);
                string filepath = "F:\\Application_CW\\application_cw-main\\WindowsFormsApp1\\bin\\Debug\\weekly_report_sorted_2.csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, false))
                {
                    for (int i = 0; i < sortTotalEarning.Count; i++)
                    {
                        Console.WriteLine(sortTotalEarning[i]);
                        file.WriteLine(sortTotalEarning[i].day + ',' + sortTotalEarning[i].noOfVisitors + ',' + sortTotalEarning[i].totalEarning);
                    }
                }
                dataGridWeeklyReport.DataSource = ShowDatagridCSV(filepath);
            }


            foreach (var row in rows)
            {
                Console.WriteLine(row.day + row.noOfVisitors + row.totalEarning);
            }
        }

        public List<WeeklyReport> ReadFromDataGrid()
        {
            List<WeeklyReport> rows = new List<WeeklyReport>();
            foreach (DataGridViewRow dr in dataGridWeeklyReport.Rows)
            {
                //Creating object of my list of type WeeklyReport
                WeeklyReport pl = new WeeklyReport();
                pl.day = dr.Cells[0].Value.ToString();
                pl.noOfVisitors = (int)dr.Cells[1].Value;
                pl.totalEarning = (int)dr.Cells[2].Value;

                //Adding pl to List<WeeklyReport> rows  
                rows.Add(pl);
            }
            return rows;
        }

        public List<WeeklyReport> sortVisitor(List<WeeklyReport> list)
        {
            int n = list.Count;
            List<WeeklyReport> temp = new List<WeeklyReport>();
            // Temp must be initialized 
            temp.Add(new WeeklyReport());

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].noOfVisitors < list[j + 1].noOfVisitors)
                    {
                        // swap temp and arr[i]
                        temp[0] = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp[0];
                    }
                }
            return list;
        }

        public List<WeeklyReport> sortEarning(List<WeeklyReport> list)
        {
            int n = list.Count;
            List<WeeklyReport> temp = new List<WeeklyReport>();
            // Temp must be initialized 
            temp.Add(new WeeklyReport());

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].totalEarning < list[j + 1].totalEarning)
                    {
                        // swap temp and arr[i]
                        temp[0] = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp[0];
                    }
                }
            return list;
        }

        List<WeeklyReport> ReadCSVReport(string filePath)
        {

            try
            {
                var sorted_data = from l in File.ReadAllLines(filePath)
                                   let data = l.Split(',')
                                   select new WeeklyReport
                                   {
                                       day = data[0],
                                       noOfVisitors = int.Parse(data[1]),
                                       totalEarning = int.Parse(data[2]),
                                   };

                return sorted_data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
