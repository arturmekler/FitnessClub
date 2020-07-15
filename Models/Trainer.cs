using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
