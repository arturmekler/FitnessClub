using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Models
{
    public class FitnessClubContext : DbContext
    {
        public FitnessClubContext (DbContextOptions<FitnessClubContext> options)
            : base(options)
        {
        }

        public DbSet<FitnessClub.Models.User> User { get; set; }
    }
}
