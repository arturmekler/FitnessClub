using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class UserFitnessLesson
    {
        public int UserFitnessLessonId { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Schedule> Schedules { get; set; }

    }
}
