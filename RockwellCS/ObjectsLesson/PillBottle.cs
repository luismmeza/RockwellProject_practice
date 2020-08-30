using System;
namespace RockwellCS.ObjectsLesson
{
    public class PillBottle : ContainerInterface
    {

        public int _Capacity { get; set; }



        public PillBottle(int Capicity)
        {
            this._Capacity = Capicity;
        }
    }
}
