using System;

namespace calculadora  
{
    class Program
    {
        static void Main(string[] args) // Punto de entrada del programa, llama a la función principal de la calculadora
        {
            Evaluacion5_CalculadoraCientifica.Ejecutar(); // Llama al método estático Ejecutar de la clase Evaluacion5_CalculadoraCientifica
        }
    }

    public static class Evaluacion5_CalculadoraCientifica // Clase estática que contiene la lógica de la calculadora científica básica
    {
        // Variable global para guardar el último resultado
        private static double ultimoResultado = 0; // Inicializado en 0 con el primer uso

        public static void Ejecutar() // Método principal que ejecuta la calculadora
        {
            bool continuar = true; // Controla el bucle principal del programa y permite salir

            while (continuar) // se usó para repetir el menú hasta que el usuario decida salir
            {
                Console.Clear();
                Console.WriteLine("///// CALCULADORA CIENTÍFICA BÁSICA /////");
                Console.WriteLine($" >>> Último resultado: {ultimoResultado}\n");

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una operación: ");

                int opcion = LeerOpcion(); // Lee la opción del usuario

                switch (opcion)
                // se usó para ejecutar la operación seleccionada por el usuario
                // el switch evalúa la variable opcion y ejecuta el bloque de código correspondiente a la opción seleccionada
                // se usó para manejar las diferentes operaciones de la calculadora
                {
                    case 1: RealizarSuma(); break;
                    case 2: RealizarResta(); break;
                    case 3: RealizarMultiplicacion(); break;
                    case 4: RealizarDivision(); break;
                    case 5: RealizarPotencia(); break;
                    case 6: RealizarRaizCuadrada(); break;
                    case 0: continuar = false; break; // se usó para salir del bucle y terminar el programa
                    default: Console.WriteLine("Opción no válida."); break; // se usó para manejar opciones inválidas
                }

                if (opcion != 0)
                // Si no se seleccionó salir, espera a que el usuario presione una tecla para continuar
                // en ete caso, se usó para pausar la ejecución y permitir al usuario ver el resultado antes de continuar
                // hasta que el usuario no decida salir, se seguira ejecutando el programa.
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("¡Gracias por usar la calculadora!");
        }

        private static int LeerOpcion()
        //el private se usó para limitar el acceso a este método solo dentro de la clase
        // se usó para leer y validar la opción ingresada por el usuario
        {
            int opcion; // lo usamos para almacenar la opción ingresada por el usuario
            while (!int.TryParse(Console.ReadLine(), out opcion)) // el ! se usó para negar el resultado de TryParse, es decir, el bucle continúa mientras la conversión falle
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion; 
        }

        private static double LeerNumero(string mensaje)
        // se usó para leer y validar un número ingresado por el usuario
        // el string mensaje se usó para personalizar el mensaje que se muestra al usuario al pedir un número
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

        private static void RealizarResta() // se usó para realizar la resta de dos números
        {
            double num1 = LeerNumero("Primer número: ");
            double num2 = LeerNumero("Segundo número: ");
            ultimoResultado = num1 - num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarMultiplicacion() // se usó para realizar la multiplicación de dos números
        {
            double num1 = LeerNumero("Primer número: ");
            double num2 = LeerNumero("Segundo número: ");
            ultimoResultado = num1 * num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarDivision() // se usó para realizar la división de dos números
        {
            double num1 = LeerNumero("Primer número: ");
            double num2; // se declaró sin inicializar para usar en el bucle do-while
            do
            {
                num2 = LeerNumero("Segundo número (diferente de 0): ");
            } while (num2 == 0);

            ultimoResultado = num1 / num2; // se usó para realizar la división
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarPotencia()
        {
            double baseNum = LeerNumero("Base: ");
            double exponente = LeerNumero("Exponente: ");
            ultimoResultado = Math.Pow(baseNum, exponente); // Math.Pow se usó para calcular la potencia
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarRaizCuadrada()
        {
            double numero;
            do
            {
                numero = LeerNumero("Número (>=0): ");
            } while (numero < 0);

            ultimoResultado = Math.Sqrt(numero); // Math.Sqrt se usó para calcular la raíz cuadrada
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }
    }
}
