using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class UserFitnessLesson
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ScheduleId { get; set; }

        public User User { get; set; }
    }
}
