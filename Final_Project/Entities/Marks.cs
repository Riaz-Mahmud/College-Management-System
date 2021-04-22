using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entities
{
    public class Marks
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Subject { get; set; }
        public float MidMarks { get; set; }
        public float FinalMarks { get; set; }
        public string Student { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }
    }
}
