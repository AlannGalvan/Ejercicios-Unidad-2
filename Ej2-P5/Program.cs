using System;

namespace Ej2_P5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para ingresar por teclado 
            //las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
            
            float n1, n2, n3, notaFinal;

            Console.WriteLine("Ingrese Nota Del Primer Examen: ");
            n1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese Nota Del Segundo Examen: ");
            n2 = float.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese Nota Del Tercer Examen: ");
            n3 = float.Parse(Console.ReadLine());

            notaFinal = (n1 + n2 + n3) / 3;

            Console.WriteLine("Promedio Final: " +  notaFinal.ToString("0.00"));

        }
    }
}
