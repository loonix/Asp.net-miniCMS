using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using miniCMS.Models;

namespace miniCMS.Data
{
    public class DbMiniCMSContext : DbContext
    {

        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbMiniCMSContext(DbContextOptions<DbMiniCMSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Conteudo>().ToTable("Conteudo");

        }
    }
}
