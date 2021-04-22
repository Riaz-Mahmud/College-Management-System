using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string Class { get; set; }
        public string SectionLimit { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public string Status { get; set; }
    }
}
