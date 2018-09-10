using System;

namespace Primo
{
    public class Program
    {
        public static void Primo(int n)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) cont++;
            }
            if (cont == 2)
                Console.WriteLine("Este es un numero primo");
            else
                Console.WriteLine("Este no es un numero primo");
        }
        public static void Main()
        {
            int n;
            Console.WriteLine("Ingrese un numero primo ");
            n = Convert.ToInt32(Console.ReadLine());
            Primo(n);

            Console.ReadKey();
        }
    }
}
