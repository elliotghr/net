using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            // rellenando o agregando elementos a la cola
            /*
            numeros.Enqueue(1);
            numeros.Enqueue(2);
            numeros.Enqueue(3);
            */

            int[] arrayNumbers = { 1, 2, 3, };

            foreach (var item in arrayNumbers)
            {
                numeros.Push(item);
            }

            // recorriendo la cola

            Console.WriteLine("Recorriendo el queue");

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Eliminando elementos del queue");

            numeros.Pop();

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            // ejercicio de trsladar un array a un queue
        }
    }
}