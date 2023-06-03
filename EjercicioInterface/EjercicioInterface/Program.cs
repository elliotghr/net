using System;

namespace EjercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Usted ha sido multado", "25-10-2023", "Gobierno");
            av2.mostrarAviso();
        }
    }
}