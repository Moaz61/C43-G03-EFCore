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
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(C => C.Topic)
                   .WithMany(T => T.Courses)
                   .HasForeignKey(C => C.TopicId);

            builder.HasMany(C => C.StudentCourses)
                   .WithOne(SC => SC.Course)
                   .HasForeignKey(SC => SC.CourseId);

            builder.HasMany(C => C.InstructorCourses)
                   .WithOne(IC =>  IC.Course)
                   .HasForeignKey(IC => IC.CourseId);
        }
    }
}
