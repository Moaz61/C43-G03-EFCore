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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(S => S.FName)
                   .HasColumnType("varchar(25)");

            builder.Property(S => S.LName)
                   .HasColumnType("varchar(25)");

            builder.HasMany(S => S.StudentCourses)
                   .WithOne(SC => SC.Student)
                   .HasForeignKey(SC => SC.StudentId);
        }
    }
}
