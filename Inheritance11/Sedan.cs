using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance11
{
    public class Sedan : Car
    {

    //This class has a country field of it's own, but also inherits make, model and year from Car.  
    //Those can be accessed through properties Make, Model, Year

        private string country;

        public string Country { get; set; }

        public Sedan()
        {

        }
    }
}
