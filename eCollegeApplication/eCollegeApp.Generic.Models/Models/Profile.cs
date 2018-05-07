using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public class Profile:TimeStampBase
    {
        public int ProfileId { get; set; }
        public byte[] ProfileImage { get; set; }

        //navigation
        public virtual Student Student { get; set; }
        public virtual Educator Educator { get; set; }
    }
}
