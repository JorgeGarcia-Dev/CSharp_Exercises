/*
Ejercicio 8

Dada una cadena de texto, comprobar si es un palíndromo o no.
Los palíndromos son palabras que se leen igual de izquierda a derecha que de derecha a izquierda.
Por ejemplo: ana, otto, kayak, ojo, etc...
*/

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa una palabra: ");
            string palabra = Console.ReadLine();
            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                System.Console.WriteLine("Es palíndromo.");
            }
            else
            {
                System.Console.WriteLine("No es palíndromo.");
            }
        }
    }
}