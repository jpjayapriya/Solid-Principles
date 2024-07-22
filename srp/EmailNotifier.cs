using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class EmailNotifier : INotifier
    {
        public void NotifyCustomer(Order order)
        {
            
            Console.WriteLine("Email notification sent to customer");
        }
    }
}
