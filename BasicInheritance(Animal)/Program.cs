using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance_Animal_
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog TreeFrog = new Frog();
            TreeFrog.Legs = 4;

            Tail<Lizard> lizTail = new Tail<Lizard>();
            Lizard BeardedDragon = new Lizard(lizTail);
            BeardedDragon.Legs = 4;
            
            Dog Corgi = new Dog();
            Corgi.Legs = 4;

            Tail<Dog> labTail = new Tail<Dog>();
            Dog Labrador = new Dog(labTail);
            Labrador.Legs = 4;

            Program animals = new Program();

            Console.WriteLine("Animals Details \r\n");
            
            animals.TreeFrogDetails(TreeFrog);
            Console.WriteLine("\r\n");
            animals.BeardedDragonDetails(BeardedDragon);
            Console.WriteLine("\r\n");
            animals.CorgiDetails(Corgi);
            Console.WriteLine("\r\n");
            animals.LabradorDetails(Labrador);
            Console.WriteLine("\r\n");

            Console.ReadLine();

            // do type checks and print to console to show what the animal is and what made up of
        }

        public void TreeFrogDetails(Frog treeFrog)
        {
            Console.WriteLine("Treefrog \r\n");
            Console.WriteLine(treeFrog.BasicAnimalStructure());
            Console.WriteLine("has " + treeFrog.Legs + " legs");
            Console.WriteLine(treeFrog.Blood());
            Console.WriteLine(treeFrog.SmoothSkin());
            Console.WriteLine("Can say " + treeFrog.Croak() + " or " + treeFrog.Ribbit());
            Console.WriteLine(treeFrog.Eat());
            Console.WriteLine(treeFrog.DigestFood());
        }

        public void BeardedDragonDetails(Lizard dragon)
        {
            Console.WriteLine("Bearded Dragon \r\n");
            Console.WriteLine(dragon.BasicAnimalStructure());
            Console.WriteLine("has " + dragon.Legs + " legs");
            Console.WriteLine("Bearded Dragon has a tail " + dragon.HasATail);
            Console.WriteLine(dragon.Blood());
            Console.WriteLine(dragon.ScalySkin());
            Console.WriteLine(dragon.Eat());
            Console.WriteLine(dragon.DigestFood());
        }

        public void CorgiDetails(Dog corgi)
        {
            Console.WriteLine("Corgi \r\n");
            Console.WriteLine(corgi.BasicAnimalStructure());
            Console.WriteLine("has " + corgi.Legs + " legs");
            Console.WriteLine(corgi.Blood());
            Console.WriteLine(corgi.LongFur());
            Console.WriteLine("Corgis can " + corgi.Bark() + " or " + corgi.Howl() + " or " + corgi.Grrrr() );
            Console.WriteLine("Corgi has a tail " + corgi.HasATail);
            Console.WriteLine(corgi.Eat());
            Console.WriteLine(corgi.DigestFood());
        }
        
        public void LabradorDetails(Dog lab)
        {
            Console.WriteLine("Labrador \r\n");
            Console.WriteLine(lab.BasicAnimalStructure());
            Console.WriteLine("has " + lab.Legs + " legs");
            Console.WriteLine(lab.Blood());
            Console.WriteLine(lab.ShortFur());
            Console.WriteLine("Labrador can " + lab.Bark() + " or " + lab.Howl() + " or " + lab.Grrrr());
            Console.WriteLine("Labrador has a tail " + lab.HasATail);
            Console.WriteLine(lab.Eat());
            Console.WriteLine(lab.DigestFood());
        }
        
    }
}
