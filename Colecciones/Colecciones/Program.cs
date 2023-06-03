using System;
// Traemos el paquete de las collections
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); // Delcaramos una lista

            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);

            //cosas que puede hacer una collection que un array no 
            //Almacenar elementos de un array
            int[] listaNumeros = new int[] { 10, 20, 30 };

            foreach (var item in listaNumeros)
            {
                numeros.Add(item);
            }
            // otra diferencia es que no necesitamos definir el numero de elementos antes de manipularlo
            Console.WriteLine("Cuántos elementos quieres introducir?");
            int elem = int.Parse(Console.ReadLine());

            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine("Introduce el elmento numero: " + (i + 1));
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            numeros.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            Console.WriteLine("Nuestra colección tiene: " + numeros.Count() + " elementos");
        }
    }
}
