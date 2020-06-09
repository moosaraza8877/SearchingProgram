using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 40, 30, 20, 60, 100, 70, 50, 10, 30, 35, 77, 1, 5, 90, 45, 12, 45, 10 };
            int x, y;
            y = 0;
            Console.Write("Enter any number that you want to check in array: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 20; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("{0} is placed at this index {1}", a[i], i);
                    y = y + 1;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("Your required number is not in the given list...!");
            }
        }
    }
}
