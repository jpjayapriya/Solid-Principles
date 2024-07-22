using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Segregation
{
    public class Printer:IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing: " + content);
        }
    }
}
