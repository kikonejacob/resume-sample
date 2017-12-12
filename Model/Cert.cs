using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace resume.Model
{
    public class Cert
    {
        public int CertId { get; set; }
        public DateTime Date { get; set; }
        public string title { get; set; }
    }
}
