using System;

namespace App
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra a verificar si es polindroma");
            String word = Console.ReadLine();
            if(esPalindroma(word)) {
                Console.WriteLine("La palabra es palíndroma");
            }
        	else {
                Console.WriteLine("La palabra NO es palíndroma");
            }
        }

        static Boolean esPalindroma(String chain){
        	Console.WriteLine("La palabra a verificar es " + chain);
        	if(chain.Length < 2) {
                return true;
            }
        	Console.WriteLine("Comparemos " + chain[0]);
        	Console.WriteLine("Con " + chain[chain.Length - 1]);
        	if(chain[0] == chain[chain.Length - 1]) {
                return esPalindroma(chain.Substring(1, chain.Length - 2));
            }
        	return false;
        }
    }
}