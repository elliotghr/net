using System;

namespace Genericos
{
    class Generico1
    {
        /*
        static void Main(string[] args)
        {
            
            AlmacenObjetos<DateTime> miAlmacen = new AlmacenObjetos<DateTime>(3);
            miAlmacen.agregar(new DateTime());
            miAlmacen.agregar(new DateTime());
            miAlmacen.agregar(new DateTime());

            // almacenamos en una variable DateTime

            DateTime fecha = miAlmacen.getElemento(2);
            Console.WriteLine("El elemento es: " + fecha);
            
            AlmacenObjetos<string> miAlmacen = new AlmacenObjetos<string>(3);
            miAlmacen.agregar("Hola");
            miAlmacen.agregar("Mundo");
            miAlmacen.agregar("!");

            Console.WriteLine("El elemento es: " + miAlmacen.getElemento(1));

            // empleados
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(3);

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));

            // almacenamos en una variable Empleado
            Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getSalario());

        }
        // Indicamos en la definición de la clase que es un generico
        class AlmacenObjetos<T>
        {
            public AlmacenObjetos(int z)
            {
                datosElemento = new T[z];
            }

            public void agregar(T obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public Object getElemento(int posicion)
            {
                return datosElemento[posicion];
            }

            // Definimos el array como generico
            private T[] datosElemento;
            private int i = 0;
        }

        class Empleado
        {
            public Empleado(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return this.salario;
            }

            private double salario;
        }
            */
    }
}
