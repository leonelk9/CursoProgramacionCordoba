using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variable de tipo integer
            // llamada "integer".
            int integer;
            // Iniciación de variable llamada
            //con valor 4.
            integer = 4;

            // Declaración e inicialición.
            int y = 3;

            float Dragon;
            Dragon = 9.6f;

            double twin;
            twin = 14000.99d;
            // Meter un valor mas peque en una mas grande
            Dragon = (int)twin;
            // Alfanumerico
            char letra = 'A';
            string frase = "Hola bichillo";
            bool booleanTrue = true;
            bool booleanFalse = false;
            Console.WriteLine(integer);
            Console.WriteLine(y);
            Console.WriteLine(Dragon);
            Console.WriteLine(twin);
            Console.WriteLine(letra);
            Console.WriteLine(frase);
            Console.WriteLine(booleanTrue);
            Console.WriteLine(booleanFalse);
            Console.WriteLine("integer: " + integer + " bool: " + booleanFalse);

            Console.ReadLine();
        }
    }
}
