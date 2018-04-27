﻿using eCollegeApp.Generic.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCollegeApp.Generic.EntityProvider.EntityConfig
{
    public class EducatorConfig:EntityTypeConfiguration<Educator>
    {
        public EducatorConfig()
        {
            HasKey(t => t.EducatorId);
            Property(t => t.FirstName).HasMaxLength(100).IsRequired();
            Property(t => t.MiddleName).HasMaxLength(50).IsOptional();
            Property(t => t.LastName).HasMaxLength(100).IsRequired();
            Property(t => t.Gender).HasMaxLength(10).IsRequired();
            Property(t => t.DOB).IsRequired();
        }
    }
}
