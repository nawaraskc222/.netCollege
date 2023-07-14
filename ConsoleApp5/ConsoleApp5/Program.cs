using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public delegate void Calculation(int a, int b);
    class Program
    {
        public static void Addition(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} = {2}", x, y, x + y);
        }
        public static void Subtraction(int x, int y)
        {
            Console.WriteLine("Difference of {0}and {1}={2}", x, y, x - y);
        }
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(Addition);
            cal.Invoke(40, 20);
            Console.ReadLine();
        }
    }
}
