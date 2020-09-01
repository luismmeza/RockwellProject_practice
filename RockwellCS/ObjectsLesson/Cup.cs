using System;
namespace RockwellCS.ObjectsLesson
{
    public class Cup : IContainer
    {
        public int _Capacity { get; set; }
        public string _ContainerType { get; set; }

        public Cup(int capcity)
        {
            _Capacity = capcity;
            _ContainerType = "Cup";
        }
            

        public void saymessage() {
            Console.WriteLine("Im a cup");
        }
    }
}
