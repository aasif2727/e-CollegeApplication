using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.Models.Models
{
    public class Student:ProfileBase
    {
        public Student()
        {
            this.Address = new Address();
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string GuardianName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public Guid StudentKey { get; set; }

        public Address Address { get; set; }
    }
}
