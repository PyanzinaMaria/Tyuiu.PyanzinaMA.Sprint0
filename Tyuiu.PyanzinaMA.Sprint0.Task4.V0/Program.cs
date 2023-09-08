using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.PyanzinaMA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(17, 5));
            Console.WriteLine(DataService.Substraction(12, 8));
            Console.WriteLine(DataService.Multiplication(3, 9));
            Console.WriteLine(DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}
