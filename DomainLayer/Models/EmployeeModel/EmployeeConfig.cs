using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EmployeeModel
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            ///
            /// Here Add all Buisness roles related the Model Specifications.
            ///
            // ID
            builder.HasKey(m => m.ID);
            builder.Property(m => m.ID)
                .ValueGeneratedOnAdd().IsRequired();
            // Name
            builder.Property(m => m.Name)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
