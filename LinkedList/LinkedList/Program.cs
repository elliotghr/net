using System;
// Traemos el paquete de las collections
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace Colecciones
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            int[] arrayNumeros = new int[] { 10, 2, 8, 7, 62 };
            foreach (var item in arrayNumeros)
            {
                //numeros.AddFirst(item);
                numeros.AddLast(item);
            }

            //numeros.Remove(8);
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            numeros.AddFirst(nodoImportante);

            /*foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            */

            // Se entiende con la documentación
            for(LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }
    }
}