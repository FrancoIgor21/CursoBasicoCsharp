using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            string Nombre ;
            int Edad ;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese Su Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese Su Edad: ");
            Edad = int.Parse(Console.ReadLine());
            //hola jeje
            Console.Write("Eres Casado?: ");
            Casado = bool.Parse (Console.ReadLine());
            Console.Write("Tu Sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());
            Console.ReadKey();









        }
    }

}