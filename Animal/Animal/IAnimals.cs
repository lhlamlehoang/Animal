using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Animal
{
    interface IAnimals
    {
        string getName();
        string getAbility();
        string getFood();
        string getImage();
    }
}
