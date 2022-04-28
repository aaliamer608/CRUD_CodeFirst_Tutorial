using CRUD_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CRUD_CF.DAL
{
    public class EmployeeContext : base("EmployeeContext")
    {
        public EmployeeContext()
            : base("EmployeeContext")
        {
        }

        public DbSet<employee> Employees { get; set; }
        public DbSet<enrollment> Enrollments { get; set; }
        public DbSet<department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<pluralizingtablenameconvention>();
        }
    }
}