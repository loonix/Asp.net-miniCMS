using Microsoft.EntityFrameworkCore;
using miniCMS.Models;

namespace miniCMS.Data
{
    public class DbMiniCMSContext : DbContext
    {
        public DbMiniCMSContext(DbContextOptions<DbMiniCMSContext> options) : base(options)
        {
        }
        public DbSet<Conteudo> Conteudos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conteudo>().ToTable("Conteudo");
        }
    }
}
