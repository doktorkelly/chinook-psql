using chinook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace chinook.DAL
{
    public class ChinookContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().ToTable("Artist", "public");
            modelBuilder.Entity<Album>().ToTable("Album", "public");
            modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();
        }
    }
}