using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer1 = new Developer("Matias", 30, "Data Engineer");
            Console.WriteLine(developer1.GetInfo());
            Console.WriteLine(developer1.GetData());
        }

        class Personas
        {
            private string _name;
            private int _age;

            public Personas(string name, int edad)
            {
                _name = name;
                _age = edad;
            }

            public string GetInfo()
            {
                return _name + ", " + _age;
            }
        }

        class Developer : Personas
        {
            private string _especialidad;
            public Developer(string name, int age, string especialidad) : base(name, age)
            {
                _especialidad = especialidad;
            }

            public string GetData()
            {
                return GetInfo() + ", " + _especialidad;
            }
        }
    }
}