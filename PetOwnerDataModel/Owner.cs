using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetOwnerDataModel
{
    public class Owner : Person
    {
        public string OwnerId { get; set; }
        public string Name
        {
            get { return FirstMidName + " " + LastName; }
        }
    }
}
