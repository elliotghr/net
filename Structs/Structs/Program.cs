using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado(3000, 1000);

            juan.cambiaSalario(juan, 500);

            Console.WriteLine(juan);

        }

        //public struct Empleado
        public class Empleado
        {
            public double salarioBase;
            public double comision;

            public Empleado(int salarioBase, int comision)
            {
                this.salarioBase = salarioBase;
                this.comision = comision;
            }
            public override string ToString()
            {
                return string.Format($"Salario y comisión del empleado {this.salarioBase} {this.comision}");
            }

            public void cambiaSalario(Empleado emp, double incremento)
            {
                emp.salarioBase += incremento;
                emp.comision += incremento;
            }
        }
    }
}