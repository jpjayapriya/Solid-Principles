namespace interface_Segregation
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                IPrinter printer = new Printer();
                IScanner scanner = new Scanner();
                MultiFunctionDevice mfd = new MultiFunctionDevice(printer, scanner);

                mfd.Print("Document to Print");
                mfd.Scan("Document to Scan");
            }
        }
    }
}