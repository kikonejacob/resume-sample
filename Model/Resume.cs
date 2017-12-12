using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.Model
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public virtual List<Education> Educations { get; set; }
        public virtual List<Cert> Certifications { get; set; }
        public virtual List<WorkHistory> WorkHistories { get; set; }

    }
}
