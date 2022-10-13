using System;

namespace App
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Enseñamos en pantalla el siguiente mensaje:
            Console.WriteLine("Introduce una palabra a verificar si es polindroma");
            // Solicitamos el ingreso del string a solicitar
            String word = Console.ReadLine();
            // Validamos si la palabra es polindroma o no con validadores if y else.
            if(esPalindroma(word)) {
                Console.WriteLine("La palabra es palíndroma");
            }
        	else {
                Console.WriteLine("La palabra NO es palíndroma");
            }
        }
        // Definimos la funcion logica para saber si la palabra pasada como parametro es polindroma
        // Al ser esta una funcion recursiva, estara ejecutandose hasta acabarse todos los caracteres a leerse.
        static Boolean esPalindroma(String chain){
            // ensenamos en consola el siguiente mensaje:
        	Console.WriteLine("La palabra a verificar es " + chain);
            // Al quedar los 2 ultimos caracteres y ser iguales, automaticamente retorna true
        	if(chain.Length < 2) {
                return true;
            }
            // enseñamos en consola las letras a comparar.
        	Console.WriteLine("Comparemos " + chain[0]);
        	Console.WriteLine("Con " + chain[chain.Length - 1]);
            // Hasta que no se complete y queden solo 2 caracteres a comparar, se seguira ejecutando la 
            // instruccion recursivamente
        	if(chain[0] == chain[chain.Length - 1]) {
                return esPalindroma(chain.Substring(1, chain.Length - 2));
            }
            // retorna un valor booleano al no coincidir logicamente los 2 caracteres a comparar.
        	return false;
        }
    }
}