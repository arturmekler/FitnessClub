using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class FitnessLesson
    {
        public FitnessLesson()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
