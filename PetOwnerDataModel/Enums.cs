using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PetOwnerDataModel
{
    public class Enums
    {
        public enum Gender
        {
            [Description("Male")]
            Male='M',
            [Description("Female")]
            Female = 'F',
            [Description("Other")]
            Other = 'O',
            [Description("Unknown")]
            Unknown = 'U'
        }

        public enum PetType
        {
            [Description("Dog")]
            Dog,
            [Description("Cat")]
            Cat
        }
    }
}
