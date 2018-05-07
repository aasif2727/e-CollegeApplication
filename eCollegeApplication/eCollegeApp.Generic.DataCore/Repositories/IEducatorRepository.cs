using eCollegeApp.Generic.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.DataCore.Repositories
{
    public interface IEducatorRepository:IRepository<Educator>
    {
        IEnumerable<Educator> GetEducatorProfileById(string employeeKey);
        IEnumerable<Student> GetAllEducatorProfileById(int pageIndex, int pageSize);
    }
}
