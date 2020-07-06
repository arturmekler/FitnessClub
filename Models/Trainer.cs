using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
    }
}
