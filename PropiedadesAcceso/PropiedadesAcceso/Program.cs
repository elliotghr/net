using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado("Juan");
            juan.SALARIO = -1200;

            Console.WriteLine("El salario del empleado es: " + juan.SALARIO);
        }

        class Empleado
        {
            // Al hacer uso de las properties añadiremos un guión bajo a los campos de clase
            private double _salario;
            private String nombre;

            public Empleado(String nombre)
            {
                this.nombre = nombre;
            }
            /*
            public double getSalario()
            {
                return salario;
            }

            public void setSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser negativo, se asignará un salario 0");
                    this.salario = 0;
                }
                else
                {
                    this.salario = salario;
                }
            }
            */

            // PROPERTIES
            // Creamos nuestro método privado
            private double evaluaSalario(double salario)
            {
                if (salario < 0)
                {
                    return 0;
                }
                else
                {
                    return salario;
                }
            }

            // CREACIÓN DE PROPERTIE
            public double SALARIO
            {
                get { return this._salario; }
                set { this._salario = evaluaSalario(value); }
            }
            // EXPRESIONES BODY CON LAMBDA
            /*
            public double SALARIO
            {
                get => this._salario;
                set => this._salario = evaluaSalario(value);
            }
            */

            // PROPERTIE SOLO ESCRITURA
            /*
            public double SALARIO
            {
                set => this._salario = evaluaSalario(value);
            }
            */

            // PROPERTIE SOLO LECTURA
            /*
            public double SALARIO
            {
                get => this._salario;

            }
            */
        }
    }
}