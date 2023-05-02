/*
Ejercicio 5

Escribir un programa para solicitar al usuario el ingreso de un número entero
y que luego imprima un valor de verdad dependiendo de si el número es par o no.
Recordad que un número es par si el resto, al dividirlo por 2, da 0.
*/

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                System.Console.WriteLine("El número es par");
            }
            else
            {
                System.Console.WriteLine("El número es impar");
            }
        }
    }
}