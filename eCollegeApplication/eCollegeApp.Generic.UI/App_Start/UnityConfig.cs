using eCollegeApp.Generic.DataCore;
using eCollegeApp.Generic.DataCore.Repositories;
using eCollegeApp.Generic.EntityProvider.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace eCollegeApp.Generic.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}