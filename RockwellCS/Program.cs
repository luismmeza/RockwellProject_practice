using System;
using RockwellCS.ObjectsLesson;

namespace RockwellCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();

            CreatePillBottle();
        }


        static void CreatePillBottle()
        {
            Console.WriteLine("What is the capacity this bottle should have?");
            

            PillBottle bottle = new PillBottle(50);
            Cup cup = new Cup(10);
            SodaBottle soda = new SodaBottle();
            soda.setCapacity(68464684);


            Console.WriteLine($"The capacity of the bottle is: {bottle._Capacity}");
            Console.Read();


            CheckCapacity(bottle);
            Console.Read();
            CheckCapacity(cup);
            Console.Read();
            CheckCapacity(soda);
            Console.Read();
        }

        static void CheckCapacity(ContainerInterface container)
        {
            Console.WriteLine(container._Capacity);
        }
    }
}
