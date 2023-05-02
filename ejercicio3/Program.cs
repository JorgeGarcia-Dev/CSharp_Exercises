/*
Ejercicio 3

Escribir un programa que solicite al usuario dos números y los almacene en dos variables.
En otra variable, almacená el resultado de la suma de esos dos números y luego mostrá ese resultado en pantalla.
A continuación, el programa debe solicitar al usuario que ingrese un tercer número, el cual se debe almacenar en una nueva variable.
Por último, mostrá en pantalla el resultado de la multiplicación de este nuevo número por el resultado de la suma anterior.
*/

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingresa otro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int suma = numero1 + numero2;
            System.Console.WriteLine($"La suma de los números es {suma}");
            System.Console.WriteLine("Ingresa otro número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int multiplicacion = numero3 * suma;
            System.Console.WriteLine($"El resultado de la multiplicación es {multiplicacion}");
        }
    }
}
