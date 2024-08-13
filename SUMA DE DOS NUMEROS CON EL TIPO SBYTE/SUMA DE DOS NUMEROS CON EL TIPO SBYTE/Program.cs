using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_DE_DOS_NUMEROS_CON_EL_TIPO_SBYTE
{
    class Program
    {
        static void Main(string[] args)
        {

            // suma de dos numeros SBYT

            Console.Write("num 1:");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("num 2:");
            sbyte num2 = sbyte.Parse(Console.ReadLine());


            int respuesta = num1 + num2;

            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);

            //pausa
            Console.ReadLine();
        }
    }
}
