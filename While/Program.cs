using System;

namespace While
{
    internal class program1
    {
        static void Main(string[] args)
        {
            int Correlativo = 0;

            while (Correlativo<=12)
            {
                Console.WriteLine("5 x "+Correlativo+" = "+(5*Correlativo));
                Correlativo++;
            }
           
            Console.ReadKey();
        }

    }

}
