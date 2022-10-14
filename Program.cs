using System;

namespace App
{
    class Programa
    {
        static void Main()
        {
            // Enseñamos en pantalla el siguiente mensaje:
            Console.WriteLine("Introduce una palabra.");
            // Solicitamos el ingreso del string a solicitar
            string word = Console.ReadLine();
            // Solicitamos el ingreso de la letra a buscar
            Console.WriteLine("Introduce una letra a buscar.");
            string character = Console.ReadLine();
            int count = wordFinder(word, character);
            Console.WriteLine("La palabra se repite " + count + " veces");
        }
        public static int wordFinder(string word, string character) {
            // Contamos las letras y llevamos un registro de coincidencias de caracteres
            // De tal manera que cada vez que "c" sea igual a "character", lleve el contador de
            // coincidencias.
            int count = 0;
            foreach (var c in word)
            {
                if (Char.ToString(c) == character) {
                    count++;
                }
            }
            return count;
        }
    }
}