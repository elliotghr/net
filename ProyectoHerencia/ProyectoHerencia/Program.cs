using System;
using System.IO;

namespace PoryectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Tiro al blanco");

            // Un caballo es una mamifero terrestre
            IMamiferosTerrestres ImiCaballo = miCaballo;

            Humano miHumano = new Humano("Laura");
            Gorila miGorila = new Gorila("Cesar");

            /*
            miCaballo.respirar();
            miHumano.respirar();
            miGorila.respirar();

            miCaballo.getNombre();
            miHumano.getNombre();
            miGorila.getNombre();
            */

            // principio de sustitución

            /*
            Mamiferos animal = new Caballo("2Pak");


            Caballo caballo = new Caballo("Pony");
            Humano humano = new Humano("Laura");
            Gorila gorila = new Gorila("Gori");

            Mamiferos[] mamiferos = new Mamiferos[3];

            mamiferos[0] = caballo;
            mamiferos[1] = humano;
            mamiferos[2] = gorila;

            // mamiferos[0].respirar();

            gorila.pensar();

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();
            Console.WriteLine("Número de patas: " + ImiCaballo.numeroPatas());

            */

            Lagartija miLagarto = new Lagartija("Juancho");

            miLagarto.respirar();

            Humano JuanHumano = new Humano("Juanito");

            JuanHumano.respirar();

            miHumano.getNombre();
            miLagarto.getNombre();
        }
    }
    // Creación de interface
    interface IMamiferosTerrestres
    {
        // solo definimos el metodo, no lo desarrollamos
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        String tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }
    // Creamos la clase abstracta
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capáz de respirar");
        }
        // Definimos el método abstracto
        public abstract void getNombre();

    }
    // Creamos la lagartija, herdando de la clase abstracta
    class Lagartija : Animales
    {
        // creamos su variable para almacenar el nombre
        private String nombreReptil;
        // creamos su constructor
        public Lagartija(String nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }
        // definimos el metodo abstracto
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }
    }
    class Mamiferos : Animales
    {
        private String nombreSerVivo;
        //remplazamos el constructor por defecto por nuestro constructor
        public Mamiferos(String nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        public virtual void pensar()
        {
            Console.WriteLine("pensamiento básico instintivo");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: " + nombreSerVivo);
        }
        /* Este metodo no nos sirve en ballena, ni para todos los mamiferos, entonces usaremos una Interface
        public int numeroPatas()
        {
            return patas;
        }
        */
    }

    class Ballena : Mamiferos
    {

        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo acuatico");

            respirar();
        }
    }
    // Heredamos Mamiferos y la interface 
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public String tipoDeporte()
        {
            return "carreras";
        }

        public Boolean esOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        // Impedimos la modificación del método con sealed
        //public sealed override void pensar()
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }

    }

    class Adolescente : Humano
    {
        public Adolescente(String nombreAdolescente) : base(nombreAdolescente)
        {
        }

        public override void pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con claridad");
        }
    }
    // Impedimos la herencia de Gorila con sealed
    sealed class Gorila : Mamiferos
    {

        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");

            respirar();
        }
        public int numeroPatas()
        {
            return 2;
        }
    }
    /*
    class Chimpance : Gorila
    {
        public Chimpance(String nombreChimpance) : base(nombreChimpance)
        {

        }
    }
    */
}