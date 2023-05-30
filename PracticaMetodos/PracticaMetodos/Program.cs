using System;

namespace PracticaMetodos
{
    class Program
    {
        int numero1 = 1;
        int numero2 = 2;

        static void Main(string[] args)
        {
            // mensajeEnPantalla();

            // Console.WriteLine("Mensaje desde el Main");

            // sumaNumeros(7,3);

            // int resultadoEntero = sumaNumerosEnteros(10, 5);
            // Console.WriteLine("La respuesta de la suma es: " + resultadoEntero);
            /*

            Console.WriteLine(suma(1,2,3));

            Console.WriteLine(Resta());


            bool isTrue = true;

            Console.WriteLine(isTrue);
            */
            /*
            Console.WriteLine("Introduce tu edad:");
            try
            {
                int myEdad = int.Parse(Console.ReadLine());
                if (myEdad <= 18)
                {
                    return;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Introduce un número correcto");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Introduce un número más corto");
            }

            Console.WriteLine("Tienes carnet?");
            string carnet = Console.ReadLine();

            if (carnet == "si")
            {
                Console.WriteLine("Adelante");
            }
            */
            /*

            string medioTransporte = "coche";

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("coche");
                    break;
                default:
                    Console.WriteLine("Ninguno");
                    break;

            }
            int multi = 0;
            while (multi < 10)
            {
                Console.WriteLine(multi);
                multi++;
            }
            */
            Console.WriteLine("Introduce tu edad:");
            try
            {
                int myEdad = int.Parse(Console.ReadLine());
                if (myEdad <= 18)
                {
                    return;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Has introducido un string, por favor, introduce un número");
            }
            catch (Exception e)
            {
                Console.WriteLine("Introduce un número correcto");
            }

            Console.WriteLine("Tienes carnet?");
            string carnet = Console.ReadLine();

            if (carnet == "si")
            {
                Console.WriteLine("Adelante");
            }
        }



        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
        }

        static void sumaNumeros(int num1, int num2)
        {
            int res = num1 + num2;

            Console.WriteLine("La respuesta de la suma es: " + res);
            Console.WriteLine($"La respuesta de la suma es: {num1 + num2}");
        }

        static int sumaNumerosEnteros(int num1, int num2)
        {
            int res = num1 + num2;

            return res;
        }

        void primerMetodo()
        {
            // int numero1 = 1;
            // int numero2 = 2;
            Console.WriteLine(numero1 + numero2);
        }

        void segundoMetodo()
        {
            Console.WriteLine(numero1);
        }

        // Sobrecarga de metodos

        static int suma(int operador1, int operador2) => operador1 + operador2;
        static int suma(int numero1, int numero2, int numero3) => numero1 + numero2 + numero3;

        // Parámetros opcionales
        private static double Resta(int v1 = 5, int v2 = 6) => v1 - v2;
    }
}