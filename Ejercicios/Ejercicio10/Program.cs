using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca su numero: ");
            int numberA = int.Parse(Console.ReadLine());

            if (numberA < 0)
                Console.WriteLine("Es negativo");
            else if (numberA > 0)
                Console.WriteLine("Es Positivo");
            else
                Console.WriteLine("Es cero");
        }
    }
}
