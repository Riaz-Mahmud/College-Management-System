using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entities
{
    public class Transaction
    {
        public int TnxId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Payment_Date { get; set; }
        public string Class { get; set; }
        public float Amount { get; set; }
        public string Type { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
    }
}
