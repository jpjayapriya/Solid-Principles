using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_close
{
    public class VIPDiscountCalculator : DiscountCalculatorOCP
    {

        public override double CalculateDiscount(Order order)
        {
            return order.Amount * 0.2;
        }

    }
}
