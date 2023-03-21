using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Animal
{
    class Cat : IAnimals
    {
        public string getName()
        {
            return "Cat";
        }
        public string getAbility()
        {
            return "Jump";
        }
        public string getFood()
        {
            return "Fish";
        }
        public string getImage()
        {
            return "cat.png";
        }
    }
}
