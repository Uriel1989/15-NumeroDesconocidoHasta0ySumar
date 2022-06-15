using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_NumeroDesconocidoHasta0ySumar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, b;

            b = 0;

            Console.WriteLine("Ingrese un numero entero: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {


                b = b + i;


            }
            Console.WriteLine("La suma de los numeros anteriores al numero ingresado es: " + b);
            Console.ReadKey();
        }
    }
}
