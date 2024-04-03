using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] amigos = new string[7]
            {
                "Hector",
                "Luis",
                "Marta",
                "Carmen",
                "Nora",
                "Osvaldo",
                null
            };

            int index = 0;
            while (index <  amigos.Length)
            {
                Console.WriteLine(amigos[index]);
                index++;
            }

            bool run = false;
            do
            {
                Console.WriteLine("Entro una vez");

            } while (run);

            // amigos[0] = "Hector";

            // Console.WriteLine(amigos[2]);

            // amigos[6] = "Carlos";

            // Console.WriteLine(amigos[6]);
        }

    }
}