using System;
using static Sobreescritura.Venta;

namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase B
            B b = new B();
            // Llamamos al método Hola() de la clase B
            Console.WriteLine(b.Hola());

            // Creamos una instancia de la clase Venta con capacidad para 10 elementos
            Venta venta = new Venta(10);
            // Añadimos dos elementos a la venta
            venta.Add(2);
            venta.Add(3);
            // Mostramos el total de la venta
            Console.WriteLine(venta.GetTotal());

            VentaConIVA ventaconiva = new VentaConIVA(10);
            ventaconiva.Add(2);
            ventaconiva.Add(3);
            Console.WriteLine(ventaconiva.GetTotal());
        }
    }

    // Definición de la clase base A
    public class A
    {
        // Método virtual que devuelve un saludo genérico
        public virtual string Hola()
        {
            return "Hola soy A";
        }
    }

    // Definición de la clase derivada B, que hereda de A
    public class B : A
    {
        // Método que sobreescribe el método Hola() de la clase A
        public override string Hola()
        {
            // Llama al método Hola() de la clase base (A) y añade un mensaje adicional
            return base.Hola() + " y " + "Hola soy B";
        }
    }

    // Definición de la clase Venta
    public class Venta
    {
        private decimal[] _cantidad; // Arreglo para almacenar las cantidades de la venta
        private int _n; // Tamaño máximo del arreglo
        private int _fin; // Índice para rastrear la posición final de las cantidades añadidas

        // Constructor que recibe el tamaño máximo del arreglo
        public Venta(int n)
        {
            // Inicializamos el arreglo con el tamaño especificado
            _cantidad = new decimal[n];
            // Inicializamos el contador de elementos a 0
            _n = n;
            // Inicializamos el índice de posición final a 0
            _fin = 0;
        }

        // Método para añadir una cantidad a la venta
        public void Add(decimal cantidad)
        {
            // Verificamos si hay espacio disponible en el arreglo
            if (_fin < _n)
            {
                // Si hay espacio, añadimos la cantidad en la posición actual de _fin
                _cantidad[_fin] = cantidad;
                // Incrementamos el contador de posición final
                _fin++;
            }
        }

        // Método virtual para obtener el total de la venta
        public virtual decimal GetTotal()
        {
            decimal result = 0; // Variable para almacenar el resultado total
            int i = 0; // Variable de control para iterar sobre el arreglo _cantidad

            // Iteramos sobre el arreglo _cantidad y sumamos todas las cantidades
            while (i < _cantidad.Length)
            {
                result += _cantidad[i];
                i++;
            }

            // Devolvemos el resultado total de la venta
            return result;
        }

        // Creamos una clase que hereda de Venta para agregarle los impuestos
        public class VentaConIVA : Venta
        {
            public VentaConIVA(int n) : base(n)
            {

            }

            public override decimal GetTotal()
            {
                return base.GetTotal() * 1.21m;
            }
        }
    }
}