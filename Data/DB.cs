using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TestTask.models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TestTask.Data
{
    public class DB : DbContext
    {
        public DB() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); 
            string con = builder.Build().GetSection("ConnectionStrings").GetSection("PostresqlConnection").Value;
            optionsBuilder.UseNpgsql(con);
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
