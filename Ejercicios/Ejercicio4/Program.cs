using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nota: ");
            int note = int.Parse(Console.ReadLine());
            switch (note)
            {
                case 10:
                case 9:
            Console.WriteLine("Sobresaliente!");
                    break;
                case 8:
                case 7:
            Console.WriteLine("Notable!");
                    break;
                case 6:
            Console.WriteLine("Bien!");
                    break;
                case 5:
            Console.WriteLine("Suficiente!");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
            Console.WriteLine("Insuficiente!");
                    break;
                default:
            Console.WriteLine("Te has equivoquio");
                    break;
            }
        }
    }
}
