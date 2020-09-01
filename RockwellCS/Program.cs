using System;
using System.Collections.Generic;
using RockwellCS.ObjectsLesson;

namespace RockwellCS
{
    class Program
    {
        static UsersLibrary _users;

        static void Main(string[] args)
        {
            Start();
        }



        static void Start() 
        {
            Startup Start = new Startup();
            Start.Start();
        }
    }
}
