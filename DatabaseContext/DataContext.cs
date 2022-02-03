using System;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DatabaseContext
{
    public class DataContext : DbContext
    {
        public DbSet<Certificates> Certificates { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Specializations> Specializations { get; set; }
        private Configuration configuration = new Configuration();

        public DataContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.ConnectionString);
        }
    }
}
