using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Setting
    {
        public static string _filePath = "visitorfile.txt";     // _filepath is private naming convention
        public static string WriteToText(string data)       // converting data to text
        {
            if (!File.Exists(_filePath))
            {
                File.Create("visitorfile.txt");
            }

            using (StreamWriter outputFile = new StreamWriter(_filePath))   // 'using' in this case denotes the scope of the StreamWriter and after the data is writen, it closes the file autmatically and removes garbage value
            {
                outputFile.WriteLine(data);
            }
            return "fhis";
        }

        // Now Read the text file.

        public static string ReadFromText()
        {
            if (File.Exists(_filePath))
            {
                string text = File.ReadAllText(_filePath);
                return text;
            }
            else
            {
                return null;
            }
        }
    }
}
