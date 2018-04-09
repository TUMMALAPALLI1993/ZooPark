using System;
using System.Collections.Generic;

namespace ZooPark.world
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Bird bird = new Bird();
            //bird.Eat();
            

            //Lion lion = new Lion("Kiran",75.0f);
            //parrot parrot = new parrot();



            List<Animal> listofanimals = new List<Animal>();
            listofanimals.Add(new Lion());
            listofanimals.Add(new Lion("lion1",85.02f));
            listofanimals.Add(new Leopard());
            listofanimals.Add(new Tiger());
            listofanimals.Add(new Tiger("Tiger1",52.55f));

            listofanimals.Add(new Shark());
            listofanimals.Add(new Dolphin());
            listofanimals.Add(new Aligator());

            listofanimals.Add(new Penguin());
            listofanimals.Add(new Owl());
            listofanimals.Add(new Parrot());

            //Console.WriteLine(listofanimals[3].GetType());

            int numberOfMammals=0; int numberOfReptiles=0; int numberOfBirds = 0;


            for (int i=0; i < listofanimals.Count; i++)
            {

                //compare list tye to class type

                if (listofanimals[i].GetType() == typeof(Lion) || listofanimals[i].GetType() == typeof(Tiger) ||
                    listofanimals[i].GetType() == typeof(Leopard))
                {
                    numberOfMammals++;
                }

                else if (listofanimals[i].GetType() == typeof(Shark) || listofanimals[i].GetType() == typeof(Dolphin) ||
                    listofanimals[i].GetType() == typeof(Aligator))
                {
                    numberOfReptiles++;
                }

                else if (listofanimals[i].GetType() == typeof(Parrot) || listofanimals[i].GetType() == typeof(Owl) ||
                    listofanimals[i].GetType() == typeof(Penguin))
                {
                    numberOfBirds++;
                }

            }

            Console.WriteLine($"ZooPark contains {numberOfMammals} mammals");
            Console.WriteLine($"ZooPark contains {numberOfReptiles} Reptiles");
            Console.WriteLine($"ZooPark contains {numberOfBirds} Birds\n");



            foreach (Animal animal in listofanimals)
            {
                Console.WriteLine($"I am {animal.GetType()} type called as {animal.Name}.....has {animal.NumberOfLegs} legs");
                animal.Eat();
            }

            Console.ReadKey();
        }
    }
}
