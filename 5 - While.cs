using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine("Valor actual de i: " + i);
                i++;
            }

            int k = 0;
            while (k < 100)
            {
                if (k > 10)
                {
                    break;
                }

                Console.WriteLine("Valor actual de k:" + k);
                k++;
            }
            
        }
    }
}