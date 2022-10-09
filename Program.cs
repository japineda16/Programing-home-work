namespace HelloWorld
{
    public class Program
    {
        // Definiendo la variable de tipo string.
        public static string? phrase;
        public static string? final;
        public static string? start;
        static void Main()
        {
            // Despliegue de log y obtencion de data.
            Console.WriteLine("Escribe una sola palabra!");
            phrase = Console.ReadLine();
            // Invoca la funcion que devuelve el inicio y final de la palabra.
            palabreo(phrase);
            // Respuesta del programa.
            Console.WriteLine("La primera letra es " + start + " y la ultima es " + final);
        }
        // Definicion de la funcion
        static void palabreo(string? palabra) {
            final = phrase.Substring(phrase.Length - 1);
            start = phrase.Substring(0,1);
        }
    }
}