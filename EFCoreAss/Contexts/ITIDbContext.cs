using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFCoreAss.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAss.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server = MOAZ\\MSSQLSERVER01; Database = ITIDb; Trusted_Connection = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
    }
}
