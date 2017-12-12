using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetOwnerDataModel
{
    public class OwnerPet
    {
        public int OwnerId { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
