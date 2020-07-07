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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.UserId);
            modelBuilder.Entity<Schedule>().HasKey(x => x.ScheduleId);
            modelBuilder.Entity<Trainer>().HasKey(x => x.TrainerId);
            modelBuilder.Entity<FitnessLesson>().HasKey(x => x.LessonId);
            modelBuilder.Entity<UserFitnessLesson>().HasKey(x => x.UserFitnessLessonId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FitnessClub.Models.FitnessLesson> FitnessLesson { get; set; }

        public DbSet<FitnessClub.Models.Schedule> Schedule { get; set; }

        public DbSet<FitnessClub.Models.User> User { get; set; }

        public DbSet<FitnessClub.Models.UserFitnessLesson> UserFitnessLesson { get; set; }

        public DbSet<FitnessClub.Models.Trainer> Trainer { get; set; }
    }
}
