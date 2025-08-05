using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad=21;
            string nombre = "igor";
            string apellido = "franco";
            double sueldo = 102302.58;
            bool casado=false;
            int edad2;
            string nombre2;
            double sueldo2;
            bool casado2;



            {
                Console.WriteLine("mi nombre es " + nombre + " " + apellido);
                Console.WriteLine("tengo " + edad + " años");
                Console.WriteLine("mi sueldo es de " + sueldo);
                Console.WriteLine("¿estas casado? " + casado);
                Console.WriteLine(" presiona enter para presentarte ");
                Console.ReadKey();
                Console.Clear();

                Console.Write("¿como es tu nombre completo?: ");
                nombre2 = Console.ReadLine();

                Console.Write("¿cuantos años tienes?: ");
                edad2 = Convert.ToInt32 (Console.ReadLine());

                Console.Write("¿de cuanto es tu sueldo?: " );
                sueldo2 = Convert.ToDouble (Console.ReadLine());

                Console.Write("¿estas casado? (true or false)");
                casado2 = Convert.ToBoolean (Console.ReadLine());
                Console.Clear ();

                Console.WriteLine(" tu nombre es " + nombre2);
                Console.WriteLine(" tu edad es " + edad2);
                Console.WriteLine(" tu sueldo es de " + sueldo2);
                Console.WriteLine(" estas casado " + casado2);
                Console.ReadKey();

                


            }
        }
    }
}
