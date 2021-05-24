using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Данные вещественного(double) типа используются значительно чаще целого типа. Они необходимы в тех случаях, когда числовые значения могут содержать дробные части.
            //Дробная часть отделяется от целой части при помощи точки.
            //double d = 0.5;

            //Считываются вещественные переменные точно также как целые, только конвертация происходит в нужный тип данных, то есть:
            //double d = Convert.ToDouble(Console.ReadLine());

            int n = 5;
            int integerDivider = 2;

            Console.WriteLine(n / integerDivider); // 2

            double doubleDivider = 2;
            Console.WriteLine(n / doubleDivider); // 2.5

            double d = 2.9;
            n = (int)(d); // 2
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}