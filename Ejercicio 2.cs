using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static double CalcularImporte(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        static void MostrarPedido(string plato , int cantidad , double importe)
        {
            Console.WriteLine($"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:F2} ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE PEDIDOS DEL DIA ===");

            double totalDia = 0;
            
            for(int i = 1 ; i <= 5; i++)
            {
                Console.WriteLine($"\nPedido {i}");
                Console.WriteLine("Nombre del plato: ");
                string plato = Console.ReadLine();

                Console.WriteLine("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio Unitario: S/");
                double precio = double.Parse(Console.ReadLine());

                double importe = CalcularImporte(cantidad, precio);
                totalDia = totalDia + importe;
                MostrarPedido(plato , cantidad , importe);
            }
            Console.WriteLine($"\nTotal vendido del dia: S/{totalDia:F2}");
        }
    }
}
