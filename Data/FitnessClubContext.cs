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
    }
}
