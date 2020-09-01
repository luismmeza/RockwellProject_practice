using System;
namespace RockwellCS.ObjectsLesson
{
    public class SodaBottle : IContainer
    {
        public int _Capacity { get; set; }
        public string _ContainerType { get; set; }

        public SodaBottle()
        {
            _ContainerType = "Soda Bottle";
        }



        public void setCapacity(int aNumberThatSomeoneWIllGiveUs)
        {
            _Capacity = aNumberThatSomeoneWIllGiveUs;
        }

        public void saymessage()
        {
            Console.WriteLine("I am a Soda Bottle");
        }
    }
}
