using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numeros = new[] { 1, 2, 3, 4 };
            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            */

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (var item in arrayElementos)
            {
                Console.WriteLine(item);
            }
        }

        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion: {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }
            return datos;
        }
    }
}