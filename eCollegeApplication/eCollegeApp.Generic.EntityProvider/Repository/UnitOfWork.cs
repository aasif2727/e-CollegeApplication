using eCollegeApp.Generic.DataCore;
using eCollegeApp.Generic.DataCore.Repositories;
using eCollegeApp.Generic.EntityProvider.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.EntityProvider.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStudentRepository Students { get; private set; }

        public IEducatorRepository Educators { get; private set; }

        private readonly CollegeDbContext _db;

        public UnitOfWork(CollegeDbContext dbContext)
        {
            this._db = dbContext;
            Students = new StudentRepository(this._db);
        }

        public int Complete()
        {
            return this._db.SaveChanges();
        }

        public void Dispose()
        {
            this._db.Dispose();
        }
    }
}
