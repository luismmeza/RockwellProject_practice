using System;
namespace RockwellCS.ObjectsLesson
{
    public class SodaBottle : ContainerInterface
    {
        public int _Capacity { get; set; }

        public SodaBottle()
        {
        }



        public void setCapacity(int aNumberThatSomeoneWIllGiveUs)
        {
            _Capacity = aNumberThatSomeoneWIllGiveUs;
        }
    }
}
