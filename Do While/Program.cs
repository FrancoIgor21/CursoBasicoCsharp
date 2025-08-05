using System;

namespace DoWhile

{
    internal class DoWhile
    {
        static void Main(string[] args)
        {

        int Numero;
        Numero = 0;

        do
        {
            Console.WriteLine("cargando "+ Numero + "%");
                Numero++;

        } while (Numero<=1);
        
        Console.ReadKey();
        }
    }
}