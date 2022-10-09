namespace HelloWorld
{
    public class Program
    {
        // Definiendo la variable de tipo string.
        public static int? square;
        public static int? area;
        public static int? perimeter;
        static void Main()
        {
            // Despliegue de log y obtencion de data.
            Console.WriteLine("Por favor indique el tamaño de uno de los lados del cuadrado.");
            square = int.Parse(Console.ReadLine());
            // Invoca la funcion, y esta devuelve tanto perimetro y superficie.
            getAreaAndPerimeter(square);
            // Respuesta del programa.
            Console.WriteLine("El perimetro es " + perimeter);
            Console.WriteLine("La superficie es " + area + "²");
        }
        // Definicion de la funcion
        static void getAreaAndPerimeter(int? info) {
            perimeter = info * 4;
            area = info * info;
        }
    }
}