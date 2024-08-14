using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldo_neto__deducciones_de_ley
{
  
        class Program
        {
            static void Main(string[] args)
            {
                // Matriz para definir los tramos y las tasas de retención
                double[,] matriz = new double[,] {
                {0.01,   472.00,  0, 0},
                {472.01, 895.24, 10, 17.67},
                {895.25, 2038.10, 20, 60.00},
                {2038.11, 9999999, 30, 288.57},
            };

                Console.Write("Salario: ");
                double sueldo = double.Parse(Console.ReadLine());

                // Cálculo de AFP e ISSS
                double afp = sueldo * 6.25 / 100;
                double isss = sueldo * 3 / 100;
                double isr = 0;

                // Resta de AFP al salario bruto
                sueldo -= afp;

                // Bucle para calcular el ISR
                for (int i = 0; i < 4; i++)
                {
                    if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                    {
                        isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                    }
                }

                // Resta de ISSS e ISR al salario
                sueldo -= isss;
                sueldo -= isr;

                // Imprime el resultado
                Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}", Math.Round(sueldo, 2), afp, isss, Math.Round(isr, 2));
                Console.ReadLine();
            }
        }
    }

   