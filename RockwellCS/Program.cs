using System;
using System.Collections.Generic;
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



            


            string stringData = "I am just a bunch of characters put together";

            char character = 'a';

            int number = 10;

            double numberDOt = 1.2345678910;

            decimal numberDotMore = 1.3265443135435135435435M;

            bool ATrueOrFalse = true;





            int[] collection = new int[30];
            List<int> list = new List<int>();
            Dictionary<string, int> StringInts = new Dictionary<string, int>();





            Console.WriteLine();


            cup.saymessage();
        }

        static void CheckCapacity(ContainerInterface container)
        {
            Console.WriteLine(container._Capacity);
        }
    }
}
