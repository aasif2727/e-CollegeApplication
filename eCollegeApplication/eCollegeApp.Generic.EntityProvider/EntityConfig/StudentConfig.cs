using eCollegeApp.Generic.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.EntityProvider.EntityConfig
{
    public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            HasKey(t => t.StudentId);
            Property(t => t.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.FirstName).HasMaxLength(100).HasColumnName("FirstName").IsRequired();
            Property(t => t.MiddleName).HasMaxLength(50).HasColumnName("MiddleName").IsOptional();
            Property(t => t.LastName).HasMaxLength(100).HasColumnName("LastName").IsRequired();
            Property(t => t.FathersName).HasMaxLength(100).IsRequired();
            Property(t => t.GuardianName).HasMaxLength(50).IsOptional();
            Property(t => t.MothersName).HasMaxLength(100).IsRequired();
            Property(t => t.Gender).HasMaxLength(10).IsRequired();
            Property(t => t.DOB).IsRequired();
            Property(t => t.Email).IsRequired();
            Property(t => t.Phone).IsOptional();
            Property(t => t.RegdNumber).IsRequired();
            ToTable("Student");

            HasOptional(t => t.StudentProfile).WithRequired(t => t.Student); //1->0..1 relationship
            //HasRequired(t => t.Profile).WithRequiredPrincipal(t => t.Student);//1->1 relationship
        }
    }
}
