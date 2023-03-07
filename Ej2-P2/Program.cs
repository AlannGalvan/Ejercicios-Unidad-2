using System;

namespace Ej2_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            
            int n1, resultado;

            Console.WriteLine("Ingrese un Número");

            n1 = int.Parse(Console.ReadLine());

            resultado = n1 * n1 * n1;

            Console.WriteLine("El Resultado De Elevar " + n1 + " Al Cubo Es Igual a: " + resultado);
        }
    }
}
