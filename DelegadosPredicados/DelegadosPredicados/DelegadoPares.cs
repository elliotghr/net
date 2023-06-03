using System;

namespace DelgadosPredicados
{
    class DelegadoPares
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaramos delegado predicado

            Predicate<int> elDelegadoBool = new Predicate<int>(DamePares);

            List<int> numPares;

            numPares = listaNumeros.FindAll(elDelegadoBool);

            foreach (var item in numPares)
            {
                Console.WriteLine(item);
            }

        }

        static bool DamePares(int numero)
        {
            if (numero % 2 == 0)
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