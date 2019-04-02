using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Frog : Reptile, IFrogSpeak
    {
        public string Croak()
        {
            return "CROAK CROAK";
        }

        public string Ribbit()
        {
            return "RIBBIT RIBBIT";
        }

        public string ScalySkin()
        {
            return "Frog has smooth skin";
        }
    }
}
