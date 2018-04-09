using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Mammal : Animal
    {
        

    }

    public interface Icarnivore
    {
        void EatMeat();
    }

    public interface Iherbivore
    {
        void EatPlants();
    }

    public class Lion : Mammal
    {
       public Lion()
        {
            base.NumberOfLegs = 4;
        }
        public Lion (string name,float height)
        {
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

    }

    public class Tiger : Mammal
    {
        public Tiger()
        {
            base.NumberOfLegs = 4;
        }
        public Tiger(string name, float height)
        {
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all other animals\n");
        }

    }

    public class Leopard : Mammal
    {
        public Leopard()
        {
            base.NumberOfLegs = 4;
        }
        public Leopard(string name, float height)
        {
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all other kind of animals\n");
        }

    }
}
