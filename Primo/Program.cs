using System;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(numPrimo(34));
        }
        public static bool numPrimo(int num)
        {
            bool u;
            if (num % 2==0)
            {
                u = true;
                return u;
            }
            else
            {
                u = false;
                return u;
            }
        }
    }
}
