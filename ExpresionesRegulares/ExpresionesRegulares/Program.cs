using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hola, mi nombre es juan y mi número de teléfono es 123-456-7890. Llámame.";

            string pattern = @"\d{3}-\d{3}-\d{4}";

            //trabajaremos con regex para crear una expresión regular con el pattern
            Regex regex = new Regex(pattern);

            MatchCollection elMatch = regex.Matches(frase);

            if (elMatch.Count > 0)
            {
                Console.WriteLine("Encontrado");
            }
            else
            {
                Console.WriteLine("No econtrado");
            }
        }
    }
}