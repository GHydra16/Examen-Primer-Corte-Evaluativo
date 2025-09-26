using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluacion5_CalculadoraCientifica.Ejecutar();
        }
    }

    public static class Evaluacion5_CalculadoraCientifica
    {
        // Variable global para guardar el último resultado
        private static double ultimoResultado = 0;

        public static void Ejecutar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== CALCULADORA CIENTÍFICA BÁSICA ===");
                Console.WriteLine($"Último resultado: {ultimoResultado}\n");

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una operación: ");

                int opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1: RealizarSuma(); break;
                    case 2: RealizarResta(); break;
                    case 3: RealizarMultiplicacion(); break;
                    case 4: RealizarDivision(); break;
                    case 5: RealizarPotencia(); break;
                    case 6: RealizarRaizCuadrada(); break;
                    case 0: continuar = false; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("¡Gracias por usar la calculadora!");
        }

        private static int LeerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        private static double LeerNumero(string mensaje)
        {
            double numero;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Ingrese un número válido: ");
            }
            return numero;
        }

        private static void RealizarSuma()
        {
            double num1 = LeerNumero("Primer número: ");
            double num2 = LeerNumero("Segundo número: ");
            ultimoResultado = num1 + num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarResta()
        {
            double num1 = LeerNumero("Primer número: ");
            double num2 = LeerNumero("Segundo número: ");
            ultimoResultado = num1 - num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarMultiplicacion()
        {
            double num1 = LeerNumero("Primer número: ");
            double num2 = LeerNumero("Segundo número: ");
            ultimoResultado = num1 * num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarDivision()
        {
            double num1 = LeerNumero("Primer número: ");
            double num2;
            do
            {
                num2 = LeerNumero("Segundo número (diferente de 0): ");
            } while (num2 == 0);

            ultimoResultado = num1 / num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarPotencia()
        {
            double baseNum = LeerNumero("Base: ");
            double exponente = LeerNumero("Exponente: ");
            ultimoResultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarRaizCuadrada()
        {
            double numero;
            do
            {
                numero = LeerNumero("Número (>=0): ");
            } while (numero < 0);

            ultimoResultado = Math.Sqrt(numero);
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }
    }
}
