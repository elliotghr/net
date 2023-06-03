namespace Enums
{

    // Es frecuente usar los enums en el namespace para que todas las clases puedan
    // acceder a estos valores constantes
    // Estos valores no son Strings
    public enum EstacionesAño
    {
        Primavera,
        Verano,
        Otorño,
        Invierno
    }

    public enum Bonos
    {
        bajo = 500, normal = 1000, bueno = 1500, extra = 3000
    }
    class Program
    {
        static void Main(string[] args)
        {
            // EJEMPLO BASICO DE LOS ENUMS
            /*
            EstacionesAño miEstacion = EstacionesAño.Primavera;

            Console.WriteLine("La estación seleccionada es: " + miEstacion);

            if (miEstacion == EstacionesAño.Primavera)
            {
                Console.WriteLine("Tenemos alergia :(");
            }
            else
            {
                Console.WriteLine("No tenemos alergia :)");
            }
            */

            // SEGUNDO EJEMPLO DE ENUMS CON VALORES
            /*
            Bonos Antonio = Bonos.bueno;

            Console.WriteLine(Antonio);

            // para imprimir el valor del bono.bueno haremos un casting

            double valorBono = (double)Antonio;
            Console.WriteLine(valorBono);

            double salarioAntonio = 1500 + valorBono;

            Console.WriteLine(salarioAntonio);
            */

            Empleado juanito = new Empleado(Bonos.extra, 22000);

            Console.WriteLine("El salario del empleado es: " + juanito.getSalario());
        }

        class Empleado
        {
            private double salario;
            private double bono;

            public Empleado(Bonos bono, double salario)
            {
                this.bono = (double)bono;
                this.salario = salario;
            }
            public double getSalario()
            {
                return this.salario + this.bono;
            }
        }
    }
}
