using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessClub.Models
{
    public partial class FitnessClubDataBaseContext : DbContext
    {
        public FitnessClubDataBaseContext()
        {
        }

        public FitnessClubDataBaseContext(DbContextOptions<FitnessClubDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FitnessLesson> FitnessLesson { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserFitnessLesson> UserFitnessLesson { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FitnessClubDataBase;Trusted_Connection=True;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FitnessLesson>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.LessonId)
                    .HasConstraintName("FK_Schedule_ToTable");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK_Schedule_ToTable_1");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserFitnessLesson>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFitnessLesson)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserFitnessLesson_ToTable");
            });
        }
    }
}
