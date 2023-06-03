using System;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            Avion avion = new Avion();
            Coche coche = new Coche();

            vehiculo.arrancarMotor();
            avion.arrancarMotor();
            coche.arrancarMotor();

            vehiculo.conducir();
            avion.conducir();
            coche.conducir();

            // Polimorfismo
            Vehiculo miVehiculo = coche;
            miVehiculo.conducir();
            miVehiculo = avion;
            miVehiculo.conducir();
        }

        class Vehiculo
        {
            public void arrancarMotor()
            {
                Console.WriteLine("Arrancando motor!");
            }

            public void pararMotor()
            {
                Console.WriteLine("Deteniendo el motor...");
            }

            public virtual void conducir()
            {
                Console.WriteLine("Conduciendo el Vehiculo");
            }
        }

        class Avion : Vehiculo
        {
            public override void conducir()
            {
                Console.WriteLine("Pilotando avión");
            }
        }

        class Coche : Vehiculo
        {
            public override void conducir()
            {
                Console.WriteLine("Manejando coche");
            }
        }
    }
}