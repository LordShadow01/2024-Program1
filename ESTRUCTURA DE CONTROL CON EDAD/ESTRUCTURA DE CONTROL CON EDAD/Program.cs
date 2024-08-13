using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_DE_CONTROL_CON_EDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. if. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
            }
            else
            {
                Console.WriteLine("Eres un adolescente, disfruta de la vida.");
                //Pausa.
                Console.ReadLine();
            }
        }
    }
}
