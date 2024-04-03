using System;

namespace _3___Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Hambre = true;
            bool Comida = false;

            if (Hambre && Comida && RestaurantAbierto("Restaurant de día", 7)) // || sirve como or
            {
                Console.WriteLine("Podés comer");
            }
            else
            {
                Console.WriteLine("No podés comer");
            }
        }

        static bool RestaurantAbierto(string Name, int Hour = 0)
        {
            if (Name == "Restaurant de día" && Hour > 8 && Hour < 23)
            {
                return true;
            }
            else if (Name == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}