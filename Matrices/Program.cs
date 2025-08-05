using System;


namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];
            Persona[0, 0] = "IGOR";
            
        

            Console.WriteLine("El valor de la matriz Persona [0, 0] = " + Persona[0, 0]);
            Console.Write("Defina el siguiente valor: ");
            Persona[1, 0] = Console.ReadLine();
            Console.WriteLine("El valor de la matriz Persona [1, 0] = " + Persona[1, 0]);



            Console.ReadKey();
        }
    }
}
