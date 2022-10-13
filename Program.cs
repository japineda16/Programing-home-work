using System;

namespace App
{
    class Programa
    {
        static void Main()
        {
            // Hacemos la peticion al usuario de los numeros a sacar el MCD
            Console.WriteLine("Ingrese el primer numero.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Buscamos el mayor y el menor de estos numeros para asignarlos a cada variable correspondiente
            // Junto con una respuesta que por ahora estara vacia.
            int max = Math.Max(number1, number2);
            int min= Math.Min(number1, number2);
            int response;
            // Creamos las iteraciones a hasta llegar a 0 en el restante.
            do
            {
                response = min; // Como resultado de cada iteracion guardamos el divisor.
                min= max%min; // Guardamos el resto en b, para asi saber cuando acaba la iteracion.
                max = response; // Pasa el diviendo al divisor.
            } while (min!= 0);
            Console.WriteLine("El M.C.D entre: " + number1 + " y " + number2 + " es " + response);
        }
    }
}