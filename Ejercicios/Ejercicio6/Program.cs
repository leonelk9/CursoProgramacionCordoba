using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca un numero: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Intruduzca otro numero: ");
            double numberB = double.Parse(Console.ReadLine());

            if (numberA == numberB)
            {
                Console.WriteLine("Son iguales!");
            }
            else
                Console.WriteLine("No  son iguales :(");

        }
    }
}
