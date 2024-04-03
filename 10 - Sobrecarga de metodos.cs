using System;

namespace SobrecargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(1, 2));
            Console.WriteLine(math.Sum("1", "2")); // Llamando al método con cadenas
        }
    }

    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        // Cambiando la firma del método para aceptar una sobrecarga con parámetros de tipo double
        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
