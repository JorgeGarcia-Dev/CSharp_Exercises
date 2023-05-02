/*
Ejercicio 4

Escribir un programa que solicite al usuario ingresar la cantidad de kilómetros recorridos por una motocicleta
y la cantidad de litros de combustible que consumió durante ese recorrido. Mostrar al usuario el consumo de combustible por kilómetro.
*/

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa la camtidad de kilometros recorridos: ");
            int kilometros = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingresa la cantidad de litros de combustible consumidos: ");
            int litros = Convert.ToInt32(Console.ReadLine());
            int consumo = kilometros / litros;
            System.Console.WriteLine($"El consumo de combustible por kilómetro es de {consumo} litros.");
        }
    }
}