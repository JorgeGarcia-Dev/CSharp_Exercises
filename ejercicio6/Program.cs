/*
Ejercicio 6

Escribir un programa que solicite al usuario el ingreso de dos números diferentes
y muestre en pantalla el mayor de los dos.
*/

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingresa un segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                System.Console.WriteLine($"El número mayor es: {numero1}");
            }
            else
            {
                System.Console.WriteLine($"El número mayor es: {numero2}");
            }
        }
    }
}