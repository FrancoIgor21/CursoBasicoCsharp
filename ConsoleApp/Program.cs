using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            bool operaciones;

            Num1 = 10;
            Num2 = 5;
            operaciones = (Num1 <= Num2);
            
            Console.WriteLine("num1 es menor que num2? "+ operaciones);
            Console.ReadKey();
        }
    }
}
