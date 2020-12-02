using System;

namespace OOPChallenges
{
    class Program
    {

        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
            }

            public string Name
            {
                get { return name; }
                set
                {
                    Name = value;
                }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                Console.WriteLine("The cat sleeps.");
                hunger += 0.2;
            }
        }


        static void Main(string[] args)
        {
            Cat newCat = new Cat("Kass", "Black");

            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
            }

            Console.WriteLine("Meow");
        }
    }
}