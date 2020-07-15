using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public int? LessonId { get; set; }
        public int? TrainerId { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }

        public FitnessLesson Lesson { get; set; }
        public Trainer Trainer { get; set; }
    }
}
