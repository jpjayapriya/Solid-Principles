using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov
{
    public class Rectangle: Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Width * Height;
        }
    }
}
