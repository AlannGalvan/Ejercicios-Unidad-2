using System;

namespace Ej2_P4
{
    class Program
    {
        static void Main(string[] args)
        {
             //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el
             //total facturado por cada empleado. Hacer un programa para ingresar el total 
             //facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            //Sueldo fijo : 15000
            //5% comision sobre el total facturado

            float totalFacturado, comision, sueldoFinal;

            // es una variable constante porque no va a ser modificada
            const float sueldoFijo = 15000;
            const float porsentajeComision = 0.05F;

            Console.WriteLine("Ingrese Total Facturado: ");
            totalFacturado= float.Parse(Console.ReadLine());

            //100% >> totalFacturado
            //5%   >> ??
            //comision = 5 * totalFacturado / 100;
            //100 * 1 = 100
            //100 * 1.32 = 132
            //100 * 1.5 = 150
            //100 * 0.90 = 90
            //100 - 100 * 0.90 = 90
            //100 * 0.10 = 90
            
            //le agrego la "F" para que lo tomo como tipo de dato Float y no double.
            comision = totalFacturado * porsentajeComision;
            //comision = totalFacturado - totalFacturado * 0.95;
            

            sueldoFinal = comision + sueldoFijo;
           
            Console.WriteLine("Sueldo Final Del Empleado: " + sueldoFinal);
        

        }
    }
}
