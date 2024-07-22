namespace open_close
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Type = "VIP", Amount = 100 };

            DiscountCalculatorOCP discountCalculator = null;

            if (order.Type == "Regular")
            {
                discountCalculator = new RegularDiscountCalculator();
            }
            else if (order.Type == "VIP")
            {
                discountCalculator = new VIPDiscountCalculator();
            }

            double discount = discountCalculator.CalculateDiscount(order);

            Console.WriteLine("Discount: " + discount);
        }
    }
}