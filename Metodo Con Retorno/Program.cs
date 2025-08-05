using System;


namespace Metodo_Con_Retorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Dias;
            double PagoxDia;

            Console.Write("Ingresa Tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa cuanto pagan por dia: ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("Ingresa Dias Trabajados: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("el dinero obtenido es de: " + TotalD(PagoxDia, Dias));

            Console.ReadKey();
        }
        static double TotalD(double P1,int P2)
        {
            double Total;
            Total = (P1 * P2);
            return Total;
        }
        
    }
}
