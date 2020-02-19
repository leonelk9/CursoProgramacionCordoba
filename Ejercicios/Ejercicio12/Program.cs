using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la nota: ");
            float numberA = float.Parse(Console.ReadLine()); 
            Console.Write("Introduzca la nota: ");
            float numberB = float.Parse(Console.ReadLine());
            Console.Write("Introduzca la nota: ");
            float numberC = float.Parse(Console.ReadLine());

            Console.WriteLine("Tu media es :" + ((numberA + numberB + numberC) / 3));
        }
    }
}
