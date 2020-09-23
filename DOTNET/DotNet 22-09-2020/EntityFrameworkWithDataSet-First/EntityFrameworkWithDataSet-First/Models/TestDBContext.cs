using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkWithDataSet_First.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=true;Database=TestDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.CityId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany()
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Cities__CountryI__25869641");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
