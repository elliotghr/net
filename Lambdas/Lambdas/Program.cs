using System;
using System.Linq.Expressions;

namespace DelgadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO COMPARAR CON LAMBDA

            Personas P1 = new Personas();
            P1.Nombre = "Juana";
            P1.Edad = 8;

            Personas P2 = new Personas();
            P2.Nombre = "María";
            P2.Edad = 7;

            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));
            
            
        }

        public delegate bool ComparaPersonas(int edad1, int edad2);


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