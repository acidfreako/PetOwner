using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: consider putting this in separate project published as nuget
namespace PetOwnerDataService.Model
{
    public class OwnerPet
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
