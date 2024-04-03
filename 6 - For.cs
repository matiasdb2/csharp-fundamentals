using System;

namespace CiclosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] amigazos = new string[5]{
                "Carlos",
                "Juan",
                "Alberto",
                "Cecilia",
                null
            };

            bool run = true;
            for (int i = 0; i < amigazos.Length && run; i++)
            {
                Console.WriteLine("Iteración de i:" + i);
            }; 
        }
    }
}
