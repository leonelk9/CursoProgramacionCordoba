using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nota: ");
            float note = float.Parse(Console.ReadLine());

            if (note <= 10 && note >= 0)
            {

            if (note <= 10 && note >= 9)
                    Console.WriteLine("Sobresaliente!");
            else if (note <= 8 && note >= 7)
                    Console.WriteLine("Notable!");
            else if (note >= 6)
                    Console.WriteLine("Bien!");
            else if (note >= 5)
                    Console.WriteLine("Suficiente!");
            else if (note >= 4 && note >= 0)
                    Console.WriteLine("Insuficiente!");
            }
            else
            {
                Console.WriteLine("Tas equivoquio!");
            }
        }
    }
}
