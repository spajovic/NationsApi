﻿using Microsoft.EntityFrameworkCore;
using NationsApi.DataAccess.Configurations;
using NationsApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationsApi.DataAccess
{
    public class NationsContext : DbContext
    {
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryFlag> CountryFlags { get; set; }
        public DbSet<CountryStat> CountryStats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUseCase> RoleUseCases { get; set; }
        public DbSet<UseCaseLog> UseCaseLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your db connection string");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurations

            modelBuilder.ApplyConfiguration(new ContinentConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CountryFlagConfiguration());
            modelBuilder.ApplyConfiguration(new CountryStatConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguraiton());
            modelBuilder.ApplyConfiguration(new RoleUseCaseConfiguration());
            modelBuilder.ApplyConfiguration(new UseCaseLogConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
