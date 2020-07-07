using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int LessonID { get; set; }
        public int TrainerID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
