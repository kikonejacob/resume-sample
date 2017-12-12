using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.Model
{
    public class Education
    {
        public int EducationId { get; set; }
        public string SchoolName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTIme { get; set; }
        public string Degree { get; set; }
    }
}
