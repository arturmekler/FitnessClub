using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public ICollection<FitnessLesson> FitnessLessons { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
