/*
Ejercici0 7

Escribir un programa para solicitar al usuario 3 números y mostrar en pantalla el menor de los 3.
*/

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ingresa un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("ingresa un segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("ingresa un tercer número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 < numero2) && (numero1 < numero3))
            {
                System.Console.WriteLine($"El número menor es: {numero1}");
            }
            else if ((numero2 < numero1) && (numero2 < numero3))
            {
                System.Console.WriteLine($"El número menor es: {numero2}");
            }
            else
            {
                System.Console.WriteLine($"El número menor es: {numero3}");
            }
        }
    }
}
