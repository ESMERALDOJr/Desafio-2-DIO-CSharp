using System;

namespace Desafio2
{
    class DIO
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i+=2)
            {
                int b = (int)Math.Pow(1, 2);
                b = i * i;
                Console.WriteLine($"{i}^2 = {b}");
            }
        }
    }
}
