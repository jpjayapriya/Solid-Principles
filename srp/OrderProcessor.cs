using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class OrderProcessor
    {
        private readonly INotifier _notifier;

        public OrderProcessor(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void ProcessOrder(Order order)
        {
            // Process the order
            Console.WriteLine("Order processed");
            _notifier.NotifyCustomer(order);
        }
    }
}
