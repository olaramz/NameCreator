using System;
using System.Collections.Generic;
using System.Text;

namespace NameCreator.Model.Entity
{
    public class BasicProfile
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        
    }
}
