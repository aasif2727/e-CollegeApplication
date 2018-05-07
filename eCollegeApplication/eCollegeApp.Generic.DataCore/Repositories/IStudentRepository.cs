using eCollegeApp.Generic.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.DataCore.Repositories
{
    public interface IStudentRepository:IRepository<Student>
    {
        IEnumerable<Student> GetStudentProfileById(string regdno);
        IEnumerable<Student> GetAllStudentProfileById(int pageIndex, int pageSize);
    }
}
