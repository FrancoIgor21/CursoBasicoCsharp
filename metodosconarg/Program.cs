using System;

namespace metodosconarg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Operacion;
            int NroOperacion;

            Console.Write("Quieres Multiplicar o Sumar? ");
            Operacion = Console.ReadLine();
            Console.Write("Que tabla desear obtener? ");
            NroOperacion = int.Parse(Console.ReadLine());

            if (Operacion == "Sumar")
            {
                Sumar(NroOperacion);
            }
            else if (Operacion == "Multiplicar")
            {
                Multiplicar(NroOperacion);
            }
            else
            {
                Console.WriteLine("Operacion No Valida");
            }

            Console.ReadKey();  
        }
        static void Sumar(int Numero)
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + (Numero + a));
            }
        }
        static void Multiplicar(int Numero)
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(Numero + " * " + a + " = " + (Numero * a));
            }
        }

    }
}
