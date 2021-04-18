using System;

namespace FibonacciDizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = 377;
            int ilk = 0;
            int iki = 1;
            int artma = 0;

            for (int i = ilk; i < fibonacci; i += iki)
            {
                if ( i >= 3 )
                {

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
