using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Intruduzca su numero: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Es par!");
            }
            else
            {
                Console.WriteLine("Es impar!");
            }
        }
    }
}
