using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class Car2
    {
        public Car2(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
