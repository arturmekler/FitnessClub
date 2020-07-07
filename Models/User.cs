using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual UserFitnessLesson UserFitnessLesson { get; set; }
    }
}
