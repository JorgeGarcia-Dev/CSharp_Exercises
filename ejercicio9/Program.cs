/*
Ejercicio 9

Escribir un programa que solicite al usuario una letra y, si es vocal, muestre el mensaje "Es vocal".
en caso de no ser vocal, muestre el mensaje "No es vocal".
*/

using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa una letra: ");
            char letra = Console.ReadLine()[0];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                System.Console.WriteLine("Es vocal.");
            }
            else
            {
                System.Console.WriteLine("No es vocal.");
            }
        }
    }
}