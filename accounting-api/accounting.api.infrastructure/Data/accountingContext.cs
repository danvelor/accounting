using accounting.api.infrastructure.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace accounting.api.infrastructure.Data
{
    public class accountingContext : DbContext
    {
        public DbSet<EmployeeDetail> EmployeeDetail { get; set;}

        public string Connection { get; set; }
        public accountingContext(string sqlConnectionString)
        {
            Connection = sqlConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection,
               sqlServerOptionsAction: sqlOptions =>
               {
                   sqlOptions.EnableRetryOnFailure(
                   maxRetryCount: 5,
                   maxRetryDelay: TimeSpan.FromSeconds(20),
                   errorNumbersToAdd: null);
               });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDetail>()
            .HasKey(x => x.id);
        }
    
    }
}
