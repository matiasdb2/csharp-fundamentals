using System;

class Program
{
    static void Main(string[] args)
    {
        int edad;

        // Solicitamos la entrada del usuario hasta que sea válida
        do
        {
            // Mostramos el mensaje de instrucciones
            Console.Write("Ingrese su edad (debe ser un valor numérico entre 1 y 99): ");

            // Leemos la entrada del usuario como una cadena
            string input = Console.ReadLine();

            // Convertimos la entrada a un número entero
            if (!int.TryParse(input, out edad))
            {
                Console.WriteLine("La entrada no es un número válido.");
                continue;
            }

            // Verificamos si la edad está dentro del rango especificado
            if (edad <= 0 || edad >= 100)
            {
                Console.WriteLine("La edad debe estar entre 1 y 99.");
            }

        } while (edad <= 0 || edad >= 100);

        // Verificamos en qué rango se encuentra la edad ingresada
        if (edad >= 0 && edad <= 11)
        {
            Console.WriteLine("Usted es un niño");
        }
        else if (edad >= 12 && edad <= 18)
        {
            Console.WriteLine("Usted es un adolescente");
        }
        else
        {
            Console.WriteLine("Usted es un adulto");
        }
    }
}

// Manejo de errores en pipeline - en C# - Try/Catch o Try/Except