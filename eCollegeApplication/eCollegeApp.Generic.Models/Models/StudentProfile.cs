using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public class StudentProfile:TimeStampBase
    {
        public int ProfileId { get; set; }
        public int StudentId { get; set; }
        public byte[] ProfileImage { get; set; }
    }
}
