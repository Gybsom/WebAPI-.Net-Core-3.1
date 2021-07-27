using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiTesteSigna.Models
{
    public partial class PetsContext : DbContext
    {
        public PetsContext()
        {
        }

        public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
        {
        }
/*
        public static object Cat { get; internal set; }*/
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cat>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cats)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cats__OwnerId__267ABA7A");
            });

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Dogs)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dogs__OwnerId__29572725");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
