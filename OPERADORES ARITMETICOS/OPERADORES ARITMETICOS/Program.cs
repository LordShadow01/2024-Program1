using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERADORES_ARITMETICOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 -> Valor correcto
            Console.WriteLine("La respuesta es: {0}", respuesta);
            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);

            //Pausa.
            Console.ReadLine();
        }
    }
}
