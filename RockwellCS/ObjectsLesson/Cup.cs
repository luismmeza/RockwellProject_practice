﻿using System;
namespace RockwellCS.ObjectsLesson
{
    public class Cup : ContainerInterface
    {
        public int _Capacity { get; set; }
        public Cup(int capcity)
        {
            _Capacity = capcity;
        }
            

        public void saymessage() {
            Console.WriteLine("Im a cup");
            Console.Read();
        }
    }
}
