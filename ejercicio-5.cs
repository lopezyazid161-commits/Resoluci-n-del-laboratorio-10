using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma_porcentajes = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("sesion numero " + i);
                Console.Write("ingrese los estudiantes presentes : ");
                int presentes = int.Parse(Console.ReadLine());
                Console.Write("ingrese los estudiantes matriculados : ");
                int matriculados = int.Parse(Console.ReadLine());
                double porsentaje = calcular_porcentaje(presentes, matriculados);

                suma_porcentajes = suma_porcentajes + porsentaje;
            }
            double promedio = suma_porcentajes / 4;
            Console.WriteLine($"el promedio es {promedio:F2}%");

            if ( promedio >= 75)
            {
                Console.WriteLine("asistencia adecuada");
            }
            else
            {
                Console.WriteLine("reforsar asistencia");
            }
        }
        public static double calcular_porcentaje(int presentes, int matriculados)
        {
            return presentes * 100 / matriculados;
        }
    }
}
