using System;

namespace Delgados
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacemos que el delegado que apunte a 2 metodos diferentes
            // Instanciamos el delegado y apuntamos a la clase y después a su metodo
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            // Utilización del delegado llamando a su método
            ElDelegado("Que tal");
            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado("Ya me voy!");
        }
        // definición del objeto delegado
        // debe ser del mismo tipo que los métodos
        delegate void ObjetoDelegado(string msj);
    }
}
// estos podrían estar en otros archivos
class MensajeBienvenida
{
    public static void SaludoBienvenida(string msj)
    {
        Console.WriteLine("Hola acabo de llegar " + msj);
    }
}

class MensajeDespedida
{
    public static void SaludoDespedida(string msj)
    {
        Console.WriteLine("Hola, ta luego " + msj);
    }
}