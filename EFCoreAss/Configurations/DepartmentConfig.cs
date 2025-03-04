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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {  
            builder.Property(D => D.Id)
                   .UseIdentityColumn(100, 1);

            builder.Property(D => D.Name)
                   .HasColumnType("varchar(50)");

            builder.Property(D => D.HiringDate)
                   .HasDefaultValueSql("getdate()");

            builder.HasMany(D => D.Students)
                   .WithOne(S => S.Department)
                   .HasForeignKey(S => S.DepartmentId);
        }
    }
}
