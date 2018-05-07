using eCollegeApp.Generic.DataCore.Repositories;
using eCollegeApp.Generic.EntityProvider.DataContext;
using eCollegeApp.Generic.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.EntityProvider.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(CollegeDbContext context) : base(context)
        {
        }

        public IEnumerable<Student> GetAllStudentProfileById(int pageIndex, int pageSize)
        {
            return dbContext.Student//.Include(c => c.Profile)
                                    .OrderBy(c => c.FirstName)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();
        }

        public IEnumerable<Student> GetStudentProfileById(string regdno)
        {
            return dbContext.Student;
        }

        public CollegeDbContext dbContext
        {
            get { return Context as CollegeDbContext; }
        }
    }
}
