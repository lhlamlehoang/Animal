using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Animal
{
    class Pig : IAnimals
    {
        public string getName()
        {
            return "Pig";
        }
        public string getAbility()
        {
            return "Eat & Sleep";
        }
        public string getFood()
        {
            return "Bran";
        }
        public string getImage()
        {
            return "pig.jpg";
        }
    }
}
