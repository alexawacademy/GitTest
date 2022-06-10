using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }


        public Cars(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }
}
