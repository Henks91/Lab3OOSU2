using Business.Classes;
using DataLayer.Seed;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Security.Authentication.ExtendedProtection;

namespace DataLayer.Context
{
    public class BokningDbContext : DbContext
    {
        public BokningDbContext() { }
        public BokningDbContext(DbContextOptions<BokningDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Grupp24MVVM;Integrated Security=True;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
            
        }
        public void Reset()
        {
            #region Remove Tables
            using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=Grupp24MVVM;Integrated Security=True;MultipleActiveResultSets=true;"))
            using (SqlCommand cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }
                conn.Close();
            }
            #endregion
        }

        public DbSet<Bok> Bok { get; set; } = null!;
        public DbSet<Bokning> Bokning { get; set; } = null!;
        public DbSet<Expidit> Expidit { get; set; } = null!;
        public DbSet<Faktura> Faktura { get; set; } = null!;
        public DbSet<Medlem> Medlem { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expidit>()
              .HasKey(e => e.AnstId);

            modelBuilder.Entity<Bokning>()
                .HasKey(bk => bk.BokningId);

            modelBuilder.Entity<Medlem>()
                .HasKey(m => m.MedlemsId);

            modelBuilder.Entity<Faktura>()
                .HasKey(f => f.FakturaId);

            modelBuilder.Entity<Bok>()
                .HasKey(b => b.Id);


            //här ska klassernas associationer hanteras beroende på dess multiplicitet.
            modelBuilder.Populate();
        }
    }
}
