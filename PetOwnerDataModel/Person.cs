using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetOwnerDataModel
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Enums.Gender Gender { get; set; }
    }
}
