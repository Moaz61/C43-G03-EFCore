using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAss.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAss.Configurations
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Id)
                   .UseIdentityColumn(10, 1);

            builder.Property(I => I.Name)
                   .HasColumnType("varchar(50)");

            builder.Property(I => I.Salary)
                   .HasColumnType("decimal(18, 2)");

            builder.Property(I => I.Bonus)
                   .HasColumnType("decimal(18, 2)");

            builder.HasOne(I => I.ManagedDepartment)
                   .WithOne(D => D.Manager)
                   .HasForeignKey<Department>(D => D.DepartmentsManagerId);

            builder.HasOne(I => I.WorksInDepartment)
                   .WithMany(D => D.Instructors)
                   .HasForeignKey(I => I.WorksInDepartmentId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(I => I.InstructorCourses)
                   .WithOne(IC => IC.Instructor)
                   .HasForeignKey(IC => IC.InstructorId);
        }
    }
}
