using System.Drawing;

namespace liskov
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle { Width = 5, Height = 10 };
            Shape square = new Square { Side = 5 };

            Console.WriteLine("Rectangle Area: " + rectangle.Area());
            Console.WriteLine("Square Area: " + square.Area()); 
        }
    }
}