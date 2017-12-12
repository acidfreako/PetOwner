using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetOwnerDataModel
{
    public class Pet
    {
        public int PetId { get; set; }
        public Enums.PetType PetType { get; set; }
    }
}
