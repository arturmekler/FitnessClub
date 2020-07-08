using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class FitnessLesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public Schedule Schedule { get; set; }
    }
}
