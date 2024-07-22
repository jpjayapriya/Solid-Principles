using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_close
{
    public abstract class DiscountCalculatorOCP
    {
        public abstract double CalculateDiscount(Order order);
    }
}
