/*
Ejercicio 2

Escribir un programa que solicite al usuario ingresar un número con decimales y almacenalo en una variable.
A continuación, el programa debe solicitar al usuario que ingrese un número entero y guardarlo en otra variable.
En una tercera variable se deberá guardar el resultado de la suma de los dos números ingresados por el usuario.
Por último, se debe mostrar en pantalla el texto “El resultado de la suma es [suma]”, donde “[suma]” se reemplazará por el resultado de la operación.
*/

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese un número con decimales: ");
            double numeroDecimal = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Ingrese un número entero: ");
            int numeroEntero = Convert.ToInt32(Console.ReadLine());
            double suma = Convert.ToDouble(numeroDecimal + numeroEntero);
            System.Console.WriteLine($"El resultado de la suma es {suma}");
        }
    }
}
