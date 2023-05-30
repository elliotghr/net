using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Circulo miCirculo; // creacion de objeto de tipo circulo. Variable/Objeto de tipo circulo

            miCirculo = new Circulo(); // Iniciación de variable. Instanciar una clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculoRojo = new Circulo();

            // miCirculo.pi = 50.45;

            Console.WriteLine(miCirculoRojo.calculoArea(9));

            */

            /*
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiaValorEuro(1.1);

            Console.WriteLine(obj.Convierte(50));
            */

            Coche coche1 = new Coche(); // crear objeto/instancia de un coche
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getRuedas());
            Console.WriteLine(coche1.getInfoCoche());

            Coche coche3 = new Coche(1000.10, 200.20);

            Console.WriteLine(coche3.getInfoCoche());
            // coche3.setExtras(true, "piel");
            Console.WriteLine(coche3.getExtras());
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; // propiedad de la clase Circulo. Campo de clase

        public double calculoArea(int radio) /// metodo de clase ¿ Qué pueden hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }


        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0)
            {
                euro = 1.253;
            }
            else
            {
                euro = nuevoValor;
            }
        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300;
            ancho = 0.800;
            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }
    }
    partial class Coche
    {

        public int getRuedas()
        {
            return ruedas;
        }

        public String getInfoCoche()
        {
            return $"Información del coche: {ruedas} ruedas, {largo} de largo y {ancho} de ancho";
        }

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {
            return $"Extras del coche: Tapiceria {tapiceria}, Climatizador: {climatizador}";
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}