using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Segregation
{
   public class Scanner:IScanner
    {
        public void Scan(string content)
        {
            Console.WriteLine("Scanning: " + content);
        }
    }
}
