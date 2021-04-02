using Domain.DatabaseConnection.ConnectionStrings;
using Domain.Models.DepartmentModel;
using Domain.Models.EmployeeModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DatabaseConnection
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlServerConnectionString.Connection());
            base.OnConfiguring(optionsBuilder);
        }

        // Data Sets
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        // Models Configuring
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }

    }
}
