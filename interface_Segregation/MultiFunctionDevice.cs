using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Segregation
{
    public class MultiFunctionDevice: IPrinter, IScanner
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionDevice(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(string content)
        {
            _printer.Print(content);
        }

        public void Scan(string content)
        {
            _scanner.Scan(content);
        }
    }
}
