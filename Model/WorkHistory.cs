using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.Model
{
    public class WorkHistory
    {
        public int WorkHistoryId { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate {get; set;}
    }
}
