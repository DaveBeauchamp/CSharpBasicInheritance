using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Frog : Reptile, IFrogSpeak, IEat
    {
        public string Croak()
        {
            return "CROAK CROAK";
        }

        public string Eat()
        {
            return "Catches bug with tongue";
        }

        public string Ribbit()
        {
            return "RIBBIT RIBBIT";
        }

        public string SmoothSkin()
        {
            return "Frog has smooth skin";
        }
    }
}
