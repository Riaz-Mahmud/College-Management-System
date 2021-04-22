using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
