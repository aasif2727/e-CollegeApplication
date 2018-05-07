using eCollegeApp.Generic.DataCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.DataCore
{
    public interface IUnitOfWork:IDisposable
    {
        IStudentRepository Students { get; }
        IEducatorRepository Educators { get; }
        int Complete();
    }
}
