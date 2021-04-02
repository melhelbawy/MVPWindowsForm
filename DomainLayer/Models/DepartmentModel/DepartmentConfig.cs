using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DepartmentModel
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // ID
            builder.HasKey(m => m.ID);
            builder.Property(m => m.ID)
                .ValueGeneratedOnAdd().IsRequired();
            // Name
            builder.Property(m => m.DepartmentName)
                .HasMaxLength(70)
                .IsRequired();
        }
    }
}
