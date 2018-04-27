using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public class Educator:ContactMode
    {
        public Educator()
        {
            this.Address = new Address();
        }
        public int EducatorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public Guid EducatorKey { get; set; }
        public Address Address { get; set; }

        //navigation
        public virtual Profile Profile { get; set; }
    }
}
