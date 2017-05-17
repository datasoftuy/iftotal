using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace total
{
    class Program
    {
        static void Main(string[] args)
        {

            int cant = 0, total = 0;
            //Ej1: Pedir la cantidad de números que desea sumar. Luego perdir cada uno de los
            //números. Mostrar el resultado.
            Console.Write("\t  * Ejercicio 1 *\n");
            Console.Write("Ingrese la cantidad de valores a sumar: ");
            cant = Convert.ToInt32(Console.ReadLine());
            total = 0;
            for (int i = 1; i <= cant; i++)
            {
                Console.Write("Ingrese un valor: ");
                total = total + Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("La suma de los valores es:  " + total);

            Console.ReadLine();




        }
    }
}
