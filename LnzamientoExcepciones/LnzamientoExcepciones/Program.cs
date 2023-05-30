using System;

namespace LanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número del mes");
            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
            Console.WriteLine(NombreDelMes(numeroMes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! fuera");
            }

            Console.WriteLine("Seguimos!");
        }

        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Feb";
                case 3:
                    return "Marzo";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}