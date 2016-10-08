using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance11
{
    public class Car
    {

    //Fields(Attributes which will be passed down through inheritance)
    //**************These are optional, they are created in the background when properties are added to class
    //**************But instructor wants to see them

        private int year;
        private string make;
        private string model;
        private string color;

        //Properties(public, make it possible for derived classes to use year, make & model)
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public Car()
        {

        }


    }
}
