using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTA_COMPUTO_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener Nota Final Computo 1 Programa 1
            Console.Write("Lab 1 Computo 1: ");
            double lab1_c1 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 1: ");
            double lab2_c1 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 1: ");
            double parcial1_c1 = double.Parse(Console.ReadLine());

            //Computo 1
            double total_c1 = (lab1_c1 + lab2_c1 + parcial1_c1) / 3;
            Console.WriteLine("La nota total del Computo 1: {0:F2}", total_c1); // POSDATA : {0:F2} Fixed-point" (punto fijo), y 2 indica el número de decimales que se deben mostrar.

            Console.WriteLine();

            //Obtener Nota Final Computo 2 Programa 1
            Console.Write("Lab 1 Computo 2: ");
            double lab1_c2 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 2: ");
            double lab2_c2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 2: ");
            double parcial1_c2 = double.Parse(Console.ReadLine());

            //Computo 2
            double total_c2 = (lab1_c2 + lab2_c2 + parcial1_c2) / 3;
            Console.WriteLine("La nota total del Computo 2: {0:F2}", total_c2);

            Console.WriteLine();

            //Obtener Nota Final Computo 3 Programa 1
            Console.Write("Lab 1 Computo 3: ");
            double lab1_c3 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 3: ");
            double lab2_c3 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 3: ");
            double parcial1_c3 = double.Parse(Console.ReadLine());

            //Computo 3
            double total_c3 = (lab1_c3 + lab2_c3 + parcial1_c3) / 3;
            Console.WriteLine("La nota total del Computo 3: {0:F2}", total_c3);

            //Nota Final de los 3 Computos
            double nota_final = (total_c1 + total_c2 + total_c3) / 3;
            Console.WriteLine("La nota final de los 3 Computos: {0:F2}", nota_final);

            //pausa
            Console.ReadLine();
        }
    }
}
