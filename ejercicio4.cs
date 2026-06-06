using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nIngrese el código (o 'salir'): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir")
                break;

            if (!int.TryParse(entrada, out int codigo))
            {
                Console.WriteLine("Número inválido.");
                continue;
            }

            int digitos = ContarDigitos(codigo);

            if (digitos >= 6 && digitos <= 8)
            {
                if (codigo < 0)
                {
                    Console.WriteLine($"Código válido, porque se evalúa como {Math.Abs(codigo)}");
                }
                else
                {
                    Console.WriteLine("Código válido");
                }
            }
            else
            {
                if (codigo == 0)
                {
                    Console.WriteLine("Código inválido, porque tiene 1 dígito");
                }
                else
                {
                    Console.WriteLine("Código inválido");
                }
            }
        }
    }

    static int ContarDigitos(int codigo)
    {
        codigo = Math.Abs(codigo);

        if (codigo == 0)
            return 1;

        int contador = 0;

        while (codigo > 0)
        {
            contador++;
            codigo /= 10;
        }

        return contador;
    }
}
   