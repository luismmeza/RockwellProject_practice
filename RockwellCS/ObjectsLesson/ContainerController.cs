using System;
using System.Collections.Generic;
using System.Text;

namespace RockwellCS.ObjectsLesson
{
    class ContainerController
    {
        public List<IContainer> _containers;
        Random _rng;

        public ContainerController()
        {
            _rng = new Random();
            CreateListOfContainers();
        }


        public void DisplayContainerMessage(IContainer container) 
        {
            container.saymessage();
        }

        public void DisplayContainerCapacity(IContainer container) 
        {
            Console.WriteLine($"I have a capacity of {container._Capacity}");
        }

        public void CreateListOfContainers() 
        {
            _containers = new List<IContainer>();
        }
        public void GenerateContainerAddToList() 
        {
            IContainer container = CreateRandomContainer();
            AddContainerToList(container);
        }
        
        
        public IContainer CreateRandomContainer() 
        {
            int random = _rng.Next(1, 4);
            if (random == 1)
            {

                PillBottle pill = new PillBottle(_rng.Next(1, 500));
                return pill;
            }
            else if (random == 2)
            {
                SodaBottle soda = new SodaBottle();
                soda._Capacity = _rng.Next(1, 500);
                return soda;
            }
            else if (random == 3)
            {
                Cup cup = new Cup(_rng.Next(1, 500));
                return cup;
            }
            else 
            {
                return null;
            }
        }
        public void AddContainerToList(IContainer container) 
        {
            _containers.Add(container);
        }
    }
}
