using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PyanzinaMA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(2, 7));
            Console.WriteLine("A - B = " + DataService.Substraction(32, 24));
            Console.WriteLine("A * B = " + DataService.Multiplication(7, 7));
            Console.WriteLine("A / B = " + DataService.Division(27, 9));
            Console.ReadKey();
        }
    }
}
