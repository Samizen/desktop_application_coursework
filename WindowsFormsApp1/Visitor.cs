using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Visitor
    {
     public Visitor() { }
        public string ticketID { get; set; }
        public string ticketName { get; set; }
        public string noOfPeople { get; set; }
        public int groupNoOfPeople { get; set; }
        public DateTime entryTime { get; set; }
        public DateTime exitTime { get; set; }
        public int age { get; set; }
        public int price { get; set; }
    }
}
