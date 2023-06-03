namespace Destructores_59
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.mensaje();
        }

        class ManejoArchivos
        {
            StreamReader archivo = null;
            int contador = 0;

            string linea;

            // definimos el constructor

            public ManejoArchivos()
            {
                archivo = new StreamReader(@"c:\texto.txt");
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }

            public void mensaje()
            {
                Console.WriteLine($"Hay {contador} lienas");
            }
            // destructor para cerrar el flujo de datos
            ~ManejoArchivos()
            {
                archivo.Close();
            }
        }

    }
}
