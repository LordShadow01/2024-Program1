using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_GRUPAL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Selecciona una opción De Estas:");
                Console.WriteLine("1. Conversor de Monedas");
                Console.WriteLine("2. Conversor de Masa");
                Console.WriteLine("3. Conversor de Volumen");
                Console.WriteLine("4. Conversor de Longitud");
                Console.WriteLine("5. Conversor de Almacenamiento");
                Console.WriteLine("6. Conversor de Tiempo");
                Console.WriteLine("7. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Conversor("Monedas", new string[] { "Dólar", "Euro", "Libra Esterlina", "Yen Japonés", "Peso Mexicano", "Franco Suizo", "Dólar Canadiense", "Dólar Australiano", "Yuan Chino", "Rupia India" },
                            new double[,] {
                            {1, 0.91, 0.77, 147.65, 18.54, 0.87, 1.37, 1.15, 7.16, 83.83},
                            {1.1, 1, 0.85, 163.95, 20.56, 0.96, 1.51, 1.18, 7.9, 92.95},
                            {1.29, 1.17, 1, 131.12, 24.13, 1.12, 1.77, 1.34, 8.38, 103.67},
                            {0.0068, 0.0061, 0.0076, 1, 0.14, 0.0095, 0.0093, 0.0087, 0.051, 0.057},
                            {0.054, 0.049, 0.041, 7.52, 1, 0.046, 0.073, 0.061, 0.38, 4.5},
                            {1.15, 1.05, 0.89, 170.95, 21.52, 1, 1.58, 1.23, 7.37, 95.9},
                            {0.73, 0.65, 0.51, 107.83, 13.42, 0.54, 1, 0.91, 5.91, 61.77},
                            {0.87, 0.85, 0.57, 38.32, 12.43, 0.59, 0.91, 1, 4.78, 55.93},
                            {0.14, 0.13, 0.12, 20.62, 5.2, 0.11, 0.19, 0.21, 1, 11.71},
                            {0.012, 0.011, 0.0097, 1.77, 0.22, 0.0094, 0.016, 0.018, 0.085, 1}
                        });
                        break; //lo que hace es que el bucle termine inmediatamente.
                    case 2:
                        Conversor("Masa", new string[] { "Gramo", "Kilogramo", "Miligramo", "Tonelada", "Libra", "Onza", "Stone", "Quintal", "Grano", "Microgramo" },
                            new double[,] {
                            {1, 0.001, 1000, 1e-6, 0.00220462, 0.03527396, 0.000157473, 1e-5, 15.4323584, 1e+6},
                            {1000, 1, 1e+6, 0.001, 2.20462, 35.27396, 0.157473, 0.01, 15432.3584, 1e+9},
                            {0.001, 1e-6, 1, 1e-9, 2.2046e-6, 3.5274e-5, 1.5747e-7, 1e-8, 0.0154324, 1000},
                            {1e+6, 1000, 1e+9, 1, 2204.62, 35273.96, 157.473, 10, 1.5432e+7, 1e+12},
                            {453.592, 0.453592, 453592, 0.000453592, 1, 16, 0.0714286, 0.00453592, 7000, 4.536e+8},
                            {28.3495, 0.0283495, 28349.5, 2.835e-5, 0.0625, 1, 0.00446429, 0.00283495, 437.5, 2.835e+7},
                            {6.35029, 6.35029, 6350.29, 0.00635029, 14, 224, 1, 0.635029, 98000, 6.35e+9},
                            {100000, 100, 1e+8, 1e-4, 220.462, 3527.4, 1.57473, 1, 1.5432e+6, 1e+11},
                            {0.0647989, 6.4799e-5, 64.7989, 6.48e-8, 0.000142857, 0.00228571, 1.02041e-5, 6.4799e-7, 1, 6.4799e+4},
                            {1e-6, 1e-9, 1, 1e-12, 2.20462e-9, 3.5274e-8, 1.57473e-10, 1e-11, 1e-6, 1}
                        });
                        break; //lo que hace es que el bucle termine inmediatamente.
                    case 3:
                        Conversor("Volumen", new string[] { "Litro", "Mililitro", "Metro cúbico", "Centímetro cúbico", "Galón", "Onza líquida", "Pinta", "Cuarto de galón", "Taza", "Barril" },
                            new double[,] {
                            {1, 1000, 0.001, 1000, 0.264172, 33.814, 2.11338, 1.05669, 4.22675, 0.00864849},
                            {0.001, 1, 1e-6, 1, 0.000264172, 0.033814, 0.00211338, 0.00105669, 0.00422675, 8.6485e-6},
                            {1000, 1e+6, 1, 1e+6, 264.172, 33814, 2113.38, 1056.69, 4226.75, 8.6485},
                            {0.001, 1, 1e-6, 1, 0.000264172, 0.033814, 0.00211338, 0.00105669, 0.00422675, 8.6485e-6},
                            {3.78541, 3785.41, 0.00378541, 3785.41, 1, 128, 8, 4, 16, 0.0328541},
                            {0.0295735, 29.5735, 2.9574e-5, 29.5735, 0.0078125, 1, 0.0625, 0.03125, 0.125, 0.000256134},
                            {0.473176, 473.176, 0.000473176, 473.176, 0.125, 16, 1, 0.5, 2, 0.004},
                            {0.946353, 946.353, 0.000946353, 946.353, 0.25, 32, 2, 1, 4, 0.008},
                            {0.236588, 236.588, 0.000236588, 236.588, 0.0625, 8, 0.5, 0.25, 1, 0.002},
                            {115.627, 115627, 0.115627, 115627, 31.5, 3968, 248, 124, 496, 1}
                        });
                        break;//lo que hace es que el bucle termine inmediatamente. :)
                    case 4:
                        Conversor("Longitud", new string[] { "Metro", "Kilómetro", "Centímetro", "Milímetro", "Milla", "Yarda", "Pulgada", "Pie", "Milla náutica", "Micrómetro" },
                            new double[,] {
                            {1, 0.001, 100, 1000, 0.000621371, 1.09361, 39.3701, 3.28084, 0.000539957, 1e+6},
                            {1000, 1, 100000, 1000000, 0.621371, 1093.61, 39370.1, 3280.84, 0.539957, 1e+9},
                            {0.01, 1e-5, 1, 10, 6.21371e-6, 10.9361, 393.701, 32.8084, 5.39957e-4, 10000},
                            {0.001, 1e-6, 0.1, 1, 6.21371e-7, 1.09361, 39.3701, 3.28084, 5.39957e-5, 1000},
                            {1609.34, 1.60934, 160934, 1609340, 1, 1760, 63360, 5280, 1.15078, 1.60934e+9},
                            {0.9144, 0.0009144, 91.44, 914.4, 0.000568182, 1, 36, 3, 0.000491823, 914400},
                            {0.0254, 2.54e-5, 2.54, 25.4, 1.5783e-5, 0.0277778, 1, 0.0833333, 0.0000145, 25400},
                            {0.3048, 0.0003048, 30.48, 304.8, 0.000189394, 0.333333, 12, 1, 0.00009144, 304800},
                            {1852, 1.852, 185200, 1852000, 1.15078, 2025.37, 72600, 6060, 1, 1.852e+6},
                            {1e-6, 1e-9, 1e-4, 1e-7, 6.21371e-10, 1.09361e-7, 3.937e-5, 3.2808e-4, 1.8e-7, 1}
                        });
                        break;//lo que hace es que el bucle termine inmediatamente.
                    case 5:
                        Conversor("Almacenamiento", new string[] { "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte", "Nibble" },
                        new double[,] {
                                {1, 0.001, 1e-6, 1e-9, 1e-12, 1e-15, 1e-18, 1e-21, 1e-24, 0.5},
                                {1000, 1, 1e-3, 1e-6, 1e-9, 1e-12, 1e-15, 1e-18, 1e-21, 500},
                                {1e+6, 1000, 1, 1e-3, 1e-6, 1e-9, 1e-12, 1e-15, 1e-18, 500000},
                                {1e+9, 1e+6, 1000, 1, 1e-3, 1e-6, 1e-9, 1e-12, 1e-15, 5e+8},
                                {1e+12, 1e+9, 1e+6, 1000, 1, 1e-3, 1e-6, 1e-9, 1e-12, 5e+11},
                                {1e+15, 1e+12, 1e+9, 1e+6, 1000, 1, 1e-3, 1e-6, 1e-9, 5e+14},
                                {1e+18, 1e+15, 1e+12, 1e+9, 1e+6, 1000, 1, 1e-3, 1e-6, 5e+17},
                                {1e+21, 1e+18, 1e+15, 1e+12, 1e+9, 1e+6, 1000, 1, 1e-3, 5e+20},
                                {1e+24, 1e+21, 1e+18, 1e+15, 1e+12, 1e+9, 1e+6, 1000, 1, 5e+23},
                                {2, 0.002, 2e-6, 2e-9, 2e-12, 2e-15, 2e-18, 2e-21, 2e-24, 1}
                        });
                        break; //lo que hace es que el bucle termine inmediatamente.
                    case 6:
                        Conversor("Tiempo", new string[] { "Segundo", "Minuto", "Hora", "Día", "Semana", "Mes", "Año", "Decenio", "Siglo", "Milenio" },
                            new double[,] {
                            {1, 0.0166667, 0.000277778, 1.15741e-5, 1.65344e-6, 5.78704e-8, 1.90129e-9, 1.90129e-10, 1.90129e-11, 1.90129e-12},
                            {60, 1, 0.0166667, 0.000694444, 0.0001, 1.9342e-6, 5.9212e-8, 5.9212e-9, 5.9212e-10, 5.9212e-11},
                            {3600, 60, 1, 0.0416667, 0.00595238, 0.000115741, 3.16888e-6, 3.16888e-7, 3.16888e-8, 3.16888e-9},
                            {86400, 1440, 24, 1, 0.142857, 0.00411523, 1.14155e-4, 1.14155e-5, 1.14155e-6, 1.14155e-7},
                            {604800, 10080, 168, 7, 1, 0.0285714, 8.0655e-4, 8.0655e-5, 8.0655e-6, 8.0655e-7},
                            {2628000, 43800, 730.001, 30.4167, 4.34514, 1, 0.0333333, 0.00333333, 0.000333333, 3.33333e-05},
                            {31536000, 525600, 8760, 365, 52.1429, 12, 1, 0.1, 0.01, 0.001},
                            {315360000, 5256000, 87600, 3650, 521.429, 120, 10, 1, 0.1, 0.01},
                            {3153600000, 52560000, 876000, 36500, 5214.29, 1200, 100, 10, 1, 0.1},
                            {31536000000, 525600000, 8760000, 365000, 52142.9, 12000, 1000, 100, 10, 1}
                        });
                        break; //lo que hace es que el bucle termine inmediatamente.
                    case 7:
                        continuar = false;
                        Console.WriteLine("¡Gracias por tu trabajo!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void Conversor(string tipo, string[] unidades, double[,] conversiones)
        {
            Console.Clear();
            Console.WriteLine($"Conversor de {tipo}");
            Console.WriteLine("Unidades disponibles para escoger:");
            for (int i = 0; i < unidades.Length; i++)     // en esta defino e inicializo una variable de control del bucle, lo que sera entero
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }

            // Solicita al usuario la unidad de origen
            Console.Write("Selecciona la unidad que usaras: ");
            int origen = int.Parse(Console.ReadLine()) - 1;

            // Solicita al usuario la unidad del destino
            Console.Write("Selecciona la unidad  en la que lo convertiras: ");
            int destino = int.Parse(Console.ReadLine()) - 1;

            // Solicita al usuario el valor a convertir
            Console.Write("Introduce el dato a convertir: ");
            double valor = double.Parse(Console.ReadLine());

            // Y este Realizara la conversión utilizando la matriz de las conversiones
            double resultado = valor * conversiones[origen, destino];
            Console.WriteLine($"{valor} {unidades[origen]} = {resultado} {unidades[destino]}");
            Console.WriteLine("Presiona cualquier tecla del teclado para continuar...");
            Console.ReadKey();
        }
    }
}
