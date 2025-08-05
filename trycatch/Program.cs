using System;


namespace trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {

                Console.Write("Ingresa Tu Edad: ");
                Edad = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error "+ ex.Message);

            }
            
           

            
            Console.ReadKey();
        }
    }
}
