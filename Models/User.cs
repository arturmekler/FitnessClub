using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class User
    {
        public User()
        {
            UserFitnessLesson = new HashSet<UserFitnessLesson>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }

        public ICollection<UserFitnessLesson> UserFitnessLesson { get; set; }
    }
}
