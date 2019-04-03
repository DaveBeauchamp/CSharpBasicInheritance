using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Dog : Mammal, IDogSpeak, IEat
    {
        public Dog()
        {
            
        }

        public Dog(Tail<Dog> tail)
        {
            tail.HasATail = true;

            if (tail.HasATail == true)
            {
                HasATail = true;
            }
        }

        public bool HasATail { get; set; }

        public string Bark()
        {
            return "BARK BARK BARK";
        }

        public string Eat()
        {
            return "Eats from bowl";
        }

        public string Grrrr()
        {
            return "GRRRRRRR";
        }

        public string Howl()
        {
            return "Hoooooooowwwwwwwllll";
        }

        public string LongFur()
        {
            return "This dog has long fur";
        }

        public string ShortFur()
        {
            return "This dog has short fur";
        }
    }

}
