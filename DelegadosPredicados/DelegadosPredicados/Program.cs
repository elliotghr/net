using System;

namespace DelgadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 18;

            Personas p2 = new Personas();
            p2.Nombre = "Maria";
            p2.Edad = 18;

            Personas p3 = new Personas();
            p3.Nombre = "Ana";
            p3.Edad = 18;

            gente.AddRange(new Personas[] { p1, p2, p3 });

            Predicate<Personas> DelegadoPeople = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(DelegadoPeople);

            Console.WriteLine(existe);


        }

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    // Primero definimos nuestra clase persona
    class Personas
    {
        // creamos sus campos
        private string nombre;
        private int edad;

        // encapsulamos sus metodos nombre y edad con Interfaces
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}