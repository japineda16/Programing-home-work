namespace HelloWorld
{
    public class Program
    {
        // Definiendo la variable de tipos long, string e int.
        public static long? toSum;
        public static string? sumString;
        public static int total = 0;
        static void Main()
        {
            // Despliegue de log y obtencion de data.
            Console.WriteLine("Por favor indique el tamaño de uno de los lados del cuadrado.");
            toSum = long.Parse(Console.ReadLine());
            // Invocamos la funcion que calcula la entrada por consola
            operation();
            Console.WriteLine("El total de " + toSum + " es " + total);
        }
        // Definicion de la funcion
        static void operation() {
            // Primero convertimos en string el parametro entrante para que lo podamos leer en un ciclo.
            sumString = toSum.ToString();
            // Creamos el ciclo para ir leyendo caracter por caracter e ir sumandolo uno a uno con la iteracion anterior.
            for (int i = 0; i < sumString.Length; i++)
            {
                total = int.Parse(sumString.Substring(i,1)) + total;
            }
        }
    }
}