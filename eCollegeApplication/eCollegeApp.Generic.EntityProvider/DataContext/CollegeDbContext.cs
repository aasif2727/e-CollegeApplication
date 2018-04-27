using eCollegeApp.Generic.EntityProvider.EntityConfig;
using eCollegeApp.Generic.Models.Models;
using System.Data.Entity;

namespace eCollegeApp.Generic.EntityProvider.DataContext
{
    public class CollegeDbContext:DbContext
    {
        public CollegeDbContext() : base("name=CollegeDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.Configurations.Add(new EducatorConfig());
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new ProfileConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Educator> Educator { get; set; }
        public DbSet<Profile> Profile { get; set; }
    }
}
