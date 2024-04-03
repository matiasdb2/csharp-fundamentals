using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 3;

            switch(op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste el 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el 2");
                    break;
                case > 3 and < 10:
                    Console.WriteLine("Fuera de rango");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}