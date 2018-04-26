using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public abstract class ProfileBase :TimeStampBase
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
