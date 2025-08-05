using System;

namespace Switch 
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            int Dia;

            Console.Write("ingrese el dia: ");
            Dia = int.Parse(Console.ReadLine());

            switch (Dia)
            {
                case 1:
                    Console.WriteLine("es lunes");
                    break;
                case 2:
                    Console.WriteLine("es martes");
                    break;
                case 3:
                    Console.WriteLine("es miercoles");
                    break;
                case 4:
                    Console.WriteLine("es jueves");
                    break;
                case 5:
                    Console.WriteLine("es viernes");
                    break;
                case 6:
                    Console.WriteLine("es sabado");
                    break;
                case 7:
                    Console.WriteLine("es domingo");
                    break;

                default:
                    Console.WriteLine("el numero de dia ingresado no es valido");
                    break;
            }






            Console.ReadKey();

        }
    }
}