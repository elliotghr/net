using System;
using System.Linq.Expressions;

namespace DelgadosPredicados
{
    class Lambda2
    {
        static void LambdaPares()
        {
            //EJERCICIO NÚMEROS PARES CON LAMBDA

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numerosPares = numeros.FindAll(x => x % 2 == 0);

            foreach (var item in numerosPares) Console.WriteLine(item);

            // foreach con lambda
            numerosPares.ForEach(numero => Console.WriteLine(numero));
        }

    }
}