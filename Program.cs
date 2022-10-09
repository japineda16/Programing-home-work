namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Solicitamos los los caracteres a desplegar y el tamaño del triangulo
            Console.WriteLine("Ingrese una letra o caracter a desplegar");
            string x = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño del triangulo");
            int ancho = Convert.ToInt32(Console.ReadLine());
            int alto = ancho;
            drawing(alto, x);
        }
        // Defino la funcion que crea el triangulo
        static void drawing(int times, string character) {
            // dibujo de cada linea (bucle externo)
            for (int fila=1; fila <= times; fila ++)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = times - fila; espacios > 0; espacios--)
                    Console.Write(" "); // espai en blanco
                    // dibuja estrellas (2º bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write(character);
                    Console.WriteLine(" ");
            }
        }
    }
}