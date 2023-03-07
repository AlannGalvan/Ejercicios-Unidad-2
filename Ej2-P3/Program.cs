using System;

namespace Ej2_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
            //y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que 
            //demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

          float km, v, tiempo;

            Console.WriteLine("Ingrese Kilometros:");
            km = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Velocidad:");
            v = float.Parse(Console.ReadLine());

            tiempo = km / v;
            // ToString("0.00") = va a ser el formato en el cual muestre el resultado.
            Console.WriteLine("Tiempo En Sera De : " + tiempo.ToString("0.00") + " Horas.. ");
        }
    }
}
