using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.Model
{
    class ResumeDb: DbContext
    {
        public ResumeDb()
            :base("name=DefaultConnection")
        { }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<WorkHistory> WorkHistory { get; set; }
        public DbSet<Cert> Cert { get; set; }
    }
}
