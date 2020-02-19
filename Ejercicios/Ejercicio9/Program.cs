using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca su numero: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Intruduzca otro numero: ");
            int numberB = int.Parse(Console.ReadLine());


            if (numberA % numberB == 0)
            {
                Console.WriteLine("Es multiplo!");
            }
            else if (numberB % numberA == 0)
            {
                Console.WriteLine("Es multiplo!");
            }
            else
            {
                Console.WriteLine("No es multiplo!");
            }
        }
    }
}
