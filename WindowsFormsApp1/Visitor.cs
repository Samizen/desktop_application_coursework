using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Visitor
    {
        public string ticketID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string isGroup { get; set; }
        public int groupOf { get; set; }

        public string entryTime { get; set; }
        
        public string exitTime { get; set; }
        public int price { get; set; }
        public string isHoliday { get; set; }

    }
       
}
