using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string dsX, dsY;
            bool realX, realY;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Comparador de Valores ---\n");
            Console.ResetColor();

            Console.WriteLine("Digite dois números para decidir o\nde maior valor.\n");

            Console.Write("Digite o primeiro número..: ");
            dsX = Console.ReadLine();

            realX = Double.TryParse(dsX, out x);

            Console.Write("Digite o segundo número...: ");
            dsY = Console.ReadLine();

            realY = Double.TryParse(dsY, out y);

            if (realX && realY)
            {
                if (x > y)
                {
                    Console.WriteLine($"\nO maior número é {x}.\n");
                }
                if (x == y)
                {
                    Console.WriteLine($"\nAmbos são iguais.\n");
                }
                if (x < y)
                {
                    Console.WriteLine($"\nO maior número é {y}.\n");
                }
            }
            else
            {
                if (realX && !realY || !realX && realY)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nUm dos valores inseridos mão é um número!\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nInsira números válidos.\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
