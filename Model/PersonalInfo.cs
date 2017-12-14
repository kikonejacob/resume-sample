using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.Model
{
    public class PersonalInfo
    {
        public int PersonalInfoId{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
    }
}
