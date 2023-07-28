using System;

namespace PruebaCSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¡Hola! Este es un programa de prueba en C#.");
            Console.WriteLine("Ingrese un número entero:");
            // AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            // Leer el número ingresado por el usuario
            string input = Console.ReadLine();

            // Intentar convertir el numero ingresado a entero
            if (int.TryParse(input, out int numero))
            {
                // Realizar una operación en matemática simple (por ejemplo, multiplicar por 2)
                int resultado = numero * 2;

                // Mostrar el resultado por pantalla
                Console.WriteLine($"El resultado de multiplicar {numero} por 2 es: {resultado}");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número entero válido.");
            }
        }
    }
}
