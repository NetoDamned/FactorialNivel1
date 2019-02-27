using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNivel1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, factorial;
            string linea;

            Console.WriteLine("Ingrese el numero del que desea saber su factorial");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            factorial = 1;
            for (int contador = 1; contador <= numero; contador++)
            {
                factorial = factorial * contador;

            }

            Console.WriteLine("Su resultado es: "+factorial);

            Console.ReadKey();
        }
    }
}
