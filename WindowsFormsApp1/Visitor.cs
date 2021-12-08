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
        public Boolean isGroup { get; set; }
        public int groupOf { get; set; }

        public string entryTime { get; set; }
        
        public string exitTime { get; set; }
        public int price { get; set; }
        public Boolean isHoliday { get; set; }

        // Empty Parameterised Constructor:
        public Visitor() { }

        // Parameterized Constructor
        public Visitor(string ticketID, string name, int age,Boolean isGroup,int groupOf,DateTime entryTime, DateTime exitTime,int price,Boolean isHoliday) {
            this.ticketID = ticketID;
            this.name = name;
            this.age = age;
            this.isGroup = isGroup;
            this.groupOf = groupOf;                
            this.entryTime = entryTime;
            this.exitTime = exitTime;
            this.price = price; 
            this.isHoliday = isHoliday;
        }
    }
       
}
