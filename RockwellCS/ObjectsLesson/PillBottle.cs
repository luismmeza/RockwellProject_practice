using System;
namespace RockwellCS.ObjectsLesson
{
    public class PillBottle : IContainer
    {

        public int _Capacity { get; set; }
        public string _ContainerType { get; set; }

        public PillBottle(int Capicity)
        {
            this._Capacity = Capicity;
            this._ContainerType = "Pill Bottle";
        }

        public void saymessage()
        {
            Console.WriteLine("I am a Pill Bottle");
        }
    }
}
