using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: consider putting this in separate project published as nuget
namespace PetOwnerDataService.Model
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
