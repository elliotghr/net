namespace Genericos
{
    interface IParaEMpleados
    {
        double getSalario();
    }
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Electricista> director = new AlmacenEmpleados<Electricista>(3);

            director.agregar(new Electricista(1500));
            director.agregar(new Electricista(2500));
            director.agregar(new Electricista(3500));

            // Generando un error:
            /*

            AlmacenEmpleados<Alumno> director = new AlmacenEmpleados<Alumno>(3);

            director.agregar(new Alumno(1500));
            director.agregar(new Alumno(2500));
            director.agregar(new Alumno(3500));
            */
        }
    }
    // nuestra clase generia solo aceptará empleados que tengan salario
    // especificamos esto con la Interface
    class AlmacenEmpleados<T> where T : IParaEMpleados
    {
        public AlmacenEmpleados(int longitud)
        {
            datosEmpleado = new T[longitud];
        }
        public void agregar(T objeto)
        {
            datosEmpleado[i] = objeto;
            i++;
        }

        public T getEmpleado(int posicion)
        {
            return datosEmpleado[posicion];

        }
        private int i = 0;
        private T[] datosEmpleado;
    }
    class Director : IParaEMpleados
    {

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        private double salario;
    }

    class Secretaria : IParaEMpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        private double salario;
    }

    class Electricista : IParaEMpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        private double salario;
    }

    class Profesor : IParaEMpleados
    {
        public Profesor(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        private double salario;
    }

    class Alumno
    {
        public Alumno(double promedio)
        {
            this.promedio = promedio;
        }

        public double getPromedio()
        {
            return this.promedio;
        }
        private double promedio;
    }
}
