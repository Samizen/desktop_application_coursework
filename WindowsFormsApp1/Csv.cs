using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Csv
    {
        DataTable dt = new DataTable();
        public void ReadCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string header in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(header));
                }
                for(int i=1; i <= lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach(string header in headerLabels)
                    {
                        dr[header]=dataWords[columnIndex++];
                    }
                }
            }
        }
    }
}

