using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TicketPrices
    {   
        
        public TicketPrices()
        {
            string filePath = "F:\\Application_CW\\application_cw-main\\WindowsFormsApp1\\bin\\Debug\\ticket_price.csv";
            ImportFromCsv(filePath);
        }

        public void ImportFromCsv(string filePath)
        {
        
            var lines = System.IO.File.ReadAllLines(filePath);
            string[] line1Data = lines[1].Split(',');
            this.priceChild1Hr = int.Parse(line1Data[1].ToString());
            this.priceChild2Hrs = int.Parse(line1Data[2].ToString());
            this.priceChild3Hrs = int.Parse(line1Data[3].ToString());
            this.priceChild4Hrs = int.Parse(line1Data[4].ToString());
            this.priceChildWholeDay= int.Parse(line1Data[5].ToString());

            string[] line2Data = lines[2].Split(',');
            this.priceAdult1Hr = int.Parse(line2Data[1].ToString());
            this.priceAdult2Hrs = int.Parse(line2Data[2].ToString());
            this.priceAdult3Hrs = int.Parse(line2Data[3].ToString());
            this.priceAdult4Hrs = int.Parse(line2Data[4].ToString());
            this.priceAdultWholeDay = int.Parse(line2Data[5].ToString());

            string[] line3Data = lines[3].Split(',');
            this.priceGroup51Hr = int.Parse(line3Data[1].ToString());
            this.priceGroup52Hrs = int.Parse(line3Data[2].ToString());
            this.priceGroup53Hrs = int.Parse(line3Data[3].ToString());
            this.priceGroup54Hrs= int.Parse(line3Data[4].ToString());
            this.priceGroup5WholeDay = int.Parse(line3Data[5].ToString());

            string[] line4Data = lines[4].Split(',');
            this.priceGroup101Hr = int.Parse(line4Data[1].ToString());
            this.priceGroup102Hrs = int.Parse(line4Data[2].ToString());
            this.priceGroup103Hrs = int.Parse(line4Data[3].ToString());
            this.priceGroup104Hrs = int.Parse(line4Data[4].ToString());
            this.priceGroup10WholeDay = int.Parse(line4Data[5].ToString());

            string[] line5Data = lines[5].Split(',');
            this.priceGroup151Hr = int.Parse(line5Data[1].ToString());
            this.priceGroup152Hrs = int.Parse(line5Data[2].ToString());
            this.priceGroup153Hrs = int.Parse(line5Data[3].ToString());
            this.priceGroup154Hrs = int.Parse(line5Data[4].ToString());
            this.priceGroup15WholeDay = int.Parse(line5Data[5].ToString());

            string[] line6Data = lines[6].Split(',');
            this.priceGroup201Hr = int.Parse(line6Data[1].ToString());
            this.priceGroup202Hrs = int.Parse(line6Data[2].ToString());
            this.priceGroup203Hrs = int.Parse(line6Data[3].ToString());
            this.priceGroup204Hrs = int.Parse(line6Data[4].ToString());
            this.priceGroup20WholeDay = int.Parse(line6Data[5].ToString());

            string[] line7Data = lines[7].Split(',');
            this.holidayDiscount = int.Parse(line7Data[1].ToString());
            
        }
        
        public int priceChild1Hr { get; set; }
        public int priceChild2Hrs { get; set; }
        public int priceChild3Hrs { get; set; }
        public int priceChild4Hrs { get; set; }
        public int priceChildWholeDay { get; set; }

        public int priceAdult1Hr { get; set; }
        public int priceAdult2Hrs { get; set; }
        public int priceAdult3Hrs { get; set; }
        public int priceAdult4Hrs { get; set; }
        public int priceAdultWholeDay { get; set; }

        public int priceGroup51Hr { get; set; }
        public int priceGroup52Hrs { get; set; }
        public int priceGroup53Hrs { get; set; }
        public int priceGroup54Hrs { get; set; }
        public int priceGroup5WholeDay { get; set; }

        public int priceGroup101Hr { get; set; }
        public int priceGroup102Hrs { get; set; }
        public int priceGroup103Hrs { get; set; }
        public int priceGroup104Hrs { get; set; }
        public int priceGroup10WholeDay { get; set; }

        public int priceGroup151Hr { get; set; }
        public int priceGroup152Hrs { get; set; }
        public int priceGroup153Hrs { get; set; }
        public int priceGroup154Hrs { get; set; }
        public int priceGroup15WholeDay { get; set; }

        public int priceGroup201Hr { get; set; }
        public int priceGroup202Hrs { get; set; }
        public int priceGroup203Hrs { get; set; }
        public int priceGroup204Hrs { get; set; }
        public int priceGroup20WholeDay { get; set; }

        public int holidayDiscount { get; set; }

       
    }
}
