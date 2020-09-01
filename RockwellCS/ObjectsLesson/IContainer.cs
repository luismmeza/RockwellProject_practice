using System;
namespace RockwellCS.ObjectsLesson
{
    public interface IContainer
    {
        public int _Capacity { get; set; }
        public string _ContainerType { get; set; }
        public void saymessage();
    }
}
