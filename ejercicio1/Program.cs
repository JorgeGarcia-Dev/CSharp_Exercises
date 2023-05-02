/*
Ejercicio 1

Escribir un programa que solicite al usuario que ingrese su nombre. El nombre se debe almacenar en una variable llamada nombre.
A continuación se debe mostrar en pantalla el texto “Ahora estás en la matrix, [usuario]”,
donde “[usuario]” se reemplazará por el nombre que el usuario haya ingresado.
*/

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            System.Console.WriteLine($"Ahora estás en la matrix, {nombre}");
        }
    }
}
