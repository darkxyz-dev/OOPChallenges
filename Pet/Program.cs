using System;

namespace Pet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            int lifespan;

            public Pet(string _name, int _weight)
            {
                name = _name;
                age = 0;
                weight = _weight;
                lifespan = 0;
            }

            public string Name
            {
                get { return name; }
            }

            public int Age
            {
                get { return age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public double Lifespan
            {
                get { return lifespan; }
            }

            public void PetStats()
            {
                Console.WriteLine($"The pets name is {name}, age {age}, weight {weight} and lifespan {lifespan}.");
            }

            public void Eat()
            {
                weight += 0.1;
            }

            public void Exercise()
            {
                weight -= 0.1;
            }

            
        }
        static void Main(string[] args)
        {
            Pet newPet = new Pet("Pedro", 0);

            for (int i = 0; i < 11; i++)
            {
                if (newPet.Weight == 0.7)
                {
                    newPet.Exercise();
                }
                else
                {
                    newPet.Eat();
                }

            }
            newPet.PetStats();

            Console.WriteLine("The hamster died");
        }
    }
}
