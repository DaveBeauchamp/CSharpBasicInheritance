using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Dog : Mammal, IDogSpeak
    {
        public string Bark()
        {
            return "BARK BARK BARK";
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
