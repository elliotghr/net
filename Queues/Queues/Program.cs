using System;
// Traemos el paquete de las collections
using System.Collections.Generic;

namespace Queues
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            // rellenando o agregando elementos a la cola
            /*
            numeros.Enqueue(1);
            numeros.Enqueue(2);
            numeros.Enqueue(3);
            */

            int[] arrayNumbers = { 1, 2, 3, };

            foreach (var item in arrayNumbers)
            {
                numeros.Enqueue(item);
            }

            // recorriendo la cola

            Console.WriteLine("Recorriendo el queue");

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Eliminando elementos del queue");

            numeros.Dequeue();

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            // ejercicio de trsladar un array a un queue
        }
    }
}