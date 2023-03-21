using Animal.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Concrete
{
    class ChosenAnimalCreation : InterfaceAnimalFactory
    {
        private int type;

        public ChosenAnimalCreation(int type)
        {
            this.type = type;
        }
        public IAnimals createAnimals()
        {
            switch (type)
            {
                case 0:
                    return new Cat();
                case 1:
                    return new Dog();
                case 2:
                    return new Pig(); ;
                case 3:
                    return new Mouse();
                default:
                    return null;
            }
        }
    }
}
