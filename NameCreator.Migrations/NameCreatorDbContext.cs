using Microsoft.EntityFrameworkCore;
using NameCreator.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameCreator.Migrations
{
   public class NameCreatorDbContext: DbContext
    {
        public NameCreatorDbContext(DbContextOptions<NameCreatorDbContext> options) : base(options)
        {
        }
        public DbSet<BasicProfile> BasicProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicProfile>().ToTable("BasicProfile");
        }
    }
}
