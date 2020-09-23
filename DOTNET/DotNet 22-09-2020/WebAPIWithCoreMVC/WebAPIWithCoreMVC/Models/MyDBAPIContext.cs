using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIWithCoreMVC.Models
{
    public partial class MyDBAPIContext : DbContext
    {
        public MyDBAPIContext()
        {
        }

        public MyDBAPIContext(DbContextOptions<MyDBAPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PRO60VG;Initial Catalog=MyDBAPI;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.prodId);

                entity.Property(e => e.prodId).HasColumnName("prodId");

                entity.Property(e => e.prodBrand)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.prodName)
                    .HasColumnName("prodName")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
