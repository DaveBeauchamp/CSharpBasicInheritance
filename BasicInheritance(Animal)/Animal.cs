using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Animal
    {
        public int Legs { get; set; }

        public string BasicAnimalStructure()
        {
            return "All animals have some form of head and body even if they don't have a neck";
        }

        public string DigestFood()
        {
            return "Animal has eaten something";
        }

    }
}
