using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitnessClub.Models;

namespace FitnessClub.Models
{
    public class FitnessClubContext : DbContext
    {
        public FitnessClubContext (DbContextOptions<FitnessClubContext> options)
            : base(options)
        {
        }


        public DbSet<FitnessClub.Models.FitnessLesson> FitnessLesson { get; set; }

        public DbSet<FitnessClub.Models.Schedule> Schedule { get; set; }

        public DbSet<FitnessClub.Models.User> User { get; set; }

        public DbSet<FitnessClub.Models.UserFitnessLesson> UserFitnessLesson { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(p => p.UserId);


            modelBuilder.Entity<Schedule>()
                .HasKey(p => p.ScheduleId);

            modelBuilder.Entity<Schedule>()
                .HasMany(p => p.FitnessLessons);

            modelBuilder.Entity<Schedule>()
                .HasMany(p => p.Trainers);


            modelBuilder.Entity<Trainer>().HasKey(x => x.TrainerId);
            modelBuilder.Entity<FitnessLesson>().HasKey(x => x.LessonId);
            modelBuilder.Entity<UserFitnessLesson>().HasKey(x => x.UserFitnessLessonId);
            modelBuilder.Entity<UserFitnessLesson>()
                .HasMany(x => x.Schedules);
            modelBuilder.Entity<UserFitnessLesson>()
                .HasMany(x => x.Users);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FitnessClub.Models.Trainer> Trainer { get; set; }
    }
}
