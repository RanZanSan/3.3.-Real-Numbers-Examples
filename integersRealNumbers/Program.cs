using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integersRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3;
            double c = a / b; // с = 1

            //int a = 5, b = 3;
            c = (double)a / b;
            Console.WriteLine(c); // 1.6666666667
            Console.ReadKey();
        }
    }
}