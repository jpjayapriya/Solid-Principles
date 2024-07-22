namespace srp
{
    public class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new EmailNotifier();
            OrderProcessor orderProcessor = new OrderProcessor(notifier);
            Order order = new Order();

            orderProcessor.ProcessOrder(order);
        }
    }
}