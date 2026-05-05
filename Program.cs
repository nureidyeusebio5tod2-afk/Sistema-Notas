using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO DE NOTAS ===");

            try
            {
                // Nombre del estudiante
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                double suma = 0;

                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"Ingrese la nota #{i}: ");
                    double nota = double.Parse(Console.ReadLine());

                    // Validar rango
                    if (nota < 0 || nota > 100)
                    {
                        throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 100.");
                    }

                    suma += nota;
                }

                double promedio = suma / 4;

                Console.WriteLine($"\nPromedio: {promedio:F2}");

                if (promedio >= 70)
                    Console.WriteLine("Estado: Aprobado");
                else
                    Console.WriteLine("Estado: Reprobado");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Debe ingresar números válidos.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n✔ Fin del programa.");
            }

            Console.ReadKey();
        }
    }
}
    

