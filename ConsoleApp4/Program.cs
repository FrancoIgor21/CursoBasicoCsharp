using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            string Nombre;
            double Sueldo;

            Console.Write("Ingrese Su Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese Su Sueldo: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());

            if (Sueldo <= 1024)
            {
                Console.WriteLine(Nombre + " El sueldo que tenes es el minimo ");

            }
            else if (Sueldo >1024 && Sueldo <= 2000)
            {
                Console.WriteLine(Nombre + " El sueldo que tenes es rentable ");
            }
            else if (Sueldo > 2000)
            {
                Console.WriteLine(Nombre + " El sueldo que tenes es generoso ");
            }


            
           
       

            

            Console.ReadKey();

        }
    }
}