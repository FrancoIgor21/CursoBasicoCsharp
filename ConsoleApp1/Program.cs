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
            int a, b ,c , d ;
            bool Resultado;
            a = 10 ;
            b = 2 ;
            c = 0 ;
            d = 205 ;
            
            Resultado = !(a > b);
            Console.WriteLine("Cual es el resultado de (a < b) " + Resultado);
            Console.ReadKey();

        }
    }

}