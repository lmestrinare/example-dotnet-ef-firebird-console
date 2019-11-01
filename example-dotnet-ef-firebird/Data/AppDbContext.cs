using example_dotnet_ef_firebird.Mapping;
using example_dotnet_ef_firebird.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace example_dotnet_ef_firebird
{
    public class AppDbContext : DbContext
    {
        
        private string connectionString = "";

        public AppDbContext()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            connectionString = configuration.GetConnectionString("ConnFirebird");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFirebird(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new SMSMap(modelBuilder.Entity<SMS>());
        }

        public DbSet<SMS> SMS { get; set; }
    }
}
