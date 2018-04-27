using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public class Profile:TimeStampBase
    {
        public int ProfileId { get; set; }
        public int MemberId { get; set; }
        public byte[] ProfileImage { get; set; }
    }
}
