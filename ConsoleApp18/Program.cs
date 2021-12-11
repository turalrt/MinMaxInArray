using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program /*task4*/
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 18, 27, 2, 100, 0, -5, 77, -24, 99 };
            int max = arr.Max ();
            int min = arr.Min ();
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
        }
    }
}
