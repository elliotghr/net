using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            // continuar por aqui
            Punto  origen = new Punto();
            Punto  destino = new Punto(2,5);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine("La distancia entre los puntos es de: " + distancia);
        }
    }
}