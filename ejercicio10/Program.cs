/*
Ejercicio 10

Escribir un programa que sume, y multiplique los elementos de una lista de enteros.
Por ejemplo: la suma de los elementos en la lista {1,2,3,4} es 10 y la multiplicación es 24.
*/

using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {1, 2, 3, 4};
            int suma = 0;
            int multip = 1;
            foreach (int numero in lista)
            {
                suma += numero;
                multip *= numero;
            }
            System.Console.WriteLine($"El resultado de la suma es: {suma}");
            System.Console.WriteLine($"El resultado de la multiplicación es: {multip}");
        }
    }
}
