using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_AlekseiVotintsev
{
    class PetClass
    {
        public PetClass(string name, string type, decimal age)
        {
            PetName = name;
            PetType = type;
            PetAge = age;
        }
        public string PetName { get; set; }
        public string PetType { get; set; }
        
        public decimal PetAge { get; set; }
    }
}
