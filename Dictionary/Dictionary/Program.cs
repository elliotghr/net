using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // definimos el tipo de dato para el par clave, valor
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // rellenamos el diccionario

            edades.Add("Elliot", 26);
            edades.Add("Nano", 10);

            edades["Kikisito"] = 7;

            // Acceder a los valores utilizando la clave
            int edadDeJuan = edades["Kikisito"]; // edadDeJuan será Kikisito a 7

            // Verificar si una clave existe en el diccionario
            bool existeKikisito = edades.ContainsKey("Kikisito");

            // Eliminar un elemento del diccionario
            edades.Remove("Elliot");

            // imprimimos los valores con la ayuda de KeyValuePair y traemos sus valores con Key y Value
            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("El nombre es: " + persona.Key + " y la edad es de " + persona.Value);
            }
        }
    }
}