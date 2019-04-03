using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    public class Lizard : Reptile, IEat
    {
        public Lizard()
        {

        }

        public Lizard(Tail<Lizard> tail)
        {
            tail.HasATail = true;

            if (tail.HasATail == true)
            {
                HasATail = true;
            }
        }

        public bool HasATail { get; set; }

        public string Eat()
        {
            return "Catches bug";
        }

        public string ScalySkin()
        {
            return "Lizard has scaly skin";
        }
    }
}
