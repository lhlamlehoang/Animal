using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Animal
{
    class Dog : IAnimals
    {
        public string getName()
        {
            return "Dog";
        }
        public string getAbility()
        {
            return "Guard";
        }
        public string getFood()
        {
            return "Bone";
        }
        public string getImage()
        {
            return "dog.jpg";
        }
    }
}
