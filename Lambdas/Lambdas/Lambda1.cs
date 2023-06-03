using System;
using System.Linq.Expressions;

namespace DelgadosPredicados
{
    class Lambda1
    {
        //public delegate int OperacionesMatematicas(int numero);
        public delegate int OperacionesMatematicas(int numero, int numero2);
        static void LambdaIntroduccion()
        {
            // PRIMER EJEMPLO
            // SIN LAMBDA
            /*
            OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);

            Console.WriteLine(operacion(5));
            */

            // CON LAMBDA
            /*
            OperacionesMatematicas operacion = new OperacionesMatematicas(num => num * num);
            Console.WriteLine(operacion(5));
            */


            // SEGUNDO EJEMPLO
            // SIN LAMBDA
            /*
            OperacionesMatematicas suma = new OperacionesMatematicas(Suma);
            Console.WriteLine(suma(5,12));
            */

            // CON LAMBDA
            OperacionesMatematicas suma = new OperacionesMatematicas((num1, num2) => num1 + num2);

            Console.WriteLine(suma(5, 12));

        }
        // MÉTODO SIN LAMBDA
        // definimos el método si no usamos lambda
        /*
        public static int Cuadrado(int num)
        {
            return num * num;
        }
        */

        // MÉTODO SIN LAMBDA
        /*
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        */

    }
}