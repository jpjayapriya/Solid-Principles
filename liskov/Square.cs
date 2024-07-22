using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public override int Area()
        {
            return Side * Side;
        }
    }
}
