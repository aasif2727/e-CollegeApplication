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
    public class ProfileConfig:EntityTypeConfiguration<Profile>
    {
        public ProfileConfig()
        {
            Property(t => t.ProfileImage).IsOptional();
            ToTable("Profile");
        }
    }
}
