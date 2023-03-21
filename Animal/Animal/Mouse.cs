using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Animal
{
    class Mouse : IAnimals
    {
        public string getName()
        {
            return "Mouse";
        }
        public string getAbility()
        {
            return "Bite";
        }
        public string getFood()
        {
            return "Cheese";
        }
        public string getImage()
        {
            return "mouse.jpg";
        }
    }
}
