using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbsys
{
    public static  class TicketManager
    {
        public static List<Ticket> Book { get; set; }

        static TicketManager()
        {
            Book = new List<Ticket>();
        }
        public class Ticket
        {
            public string MovieNo { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string TotalAmount { get; set; }
        }
    }
}
