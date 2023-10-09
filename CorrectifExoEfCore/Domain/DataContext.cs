using CorrectifExoEfCore.Domain.EntitiesConfig;
using CorrectifExoEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoEfCore.Domain
{
    public class DataContext : DbContext
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechniNetCorrectifEFCore;Integrated Security=True;";

        public DbSet<Film> MovieList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
        }
    }
}
