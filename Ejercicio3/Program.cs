using System;

namespace evolucion
{
    /// EVALUACIÓN 3: Juego de Adivinanza Mejorado.
    /// - Usa variable global para el número secreto.
    /// - Un método con variables locales pide la adivinanza.
    /// - Otro método incrementa un contador global y muestra acierto/error.

    public static class Evaluacion3_JuegoAdivinanzaMejorado
    {
        
        // Variables globales
       

        /// Número secreto del juego (1 a 100). Si vale 0, significa que se debe iniciar un nuevo juego.

        private static int numeroSecreto = 0;

        /// Contador global de intentos realizados por el usuario.

        private static int intentosAdivinanza = 0;

        /// Generador de números aleatorios (compartido para evitar reseed).
  
        private static readonly Random rng = new Random();

        /// Punto de ejecución del juego. Inicializa el número secreto si es necesario y
        /// itera pidiendo intentos hasta que el usuario acierte.

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 3: JUEGO DE ADIVINANZA MEJORADO ===");

            // Si no hay juego en curso, se genera uno nuevo
            if (numeroSecreto == 0)
            {
                numeroSecreto = rng.Next(1, 101); // rango [1, 100]
                intentosAdivinanza = 0;           // reinicia contador global
                Console.WriteLine("Nuevo juego iniciado. Número secreto generado (1-100).");
            }

            bool acerto = false;

            // Bucle principal: se repite hasta que el usuario acierte
            while (!acerto)
            {
                // 1) Método con variables locales: pide y valida la entrada del usuario
                int intento = PedirIntento();

                // 2) "Otro método" incrementa el contador global y muestra acierto/error
                acerto = VerificarIntento(intento);
            }
        }

        /// Pide al usuario que ingrese un número, validando que sea entero y esté en el rango 1–100.
        /// <returns>Entero válido ingresado por el usuario.</returns>
        private static int PedirIntento()
        {
            // Variable local: intento
            int intento;

            Console.Write("Adivine el número (1-100): ");

            // Valida que sea un entero y que esté en el rango permitido
            while (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100)
            {
                Console.Write("Entrada inválida. Ingrese un número entre 1 y 100: ");
            }

            return intento;
        }

        /// Incrementa el contador global de intentos y muestra un mensaje de acierto o de pista (mayor/menor).
        /// <param name="intento">El valor ingresado por el usuario (ya validado).</param>
        /// true si el usuario acertó; false en caso contrario (para continuar intentando).
        /// </returns>
        private static bool VerificarIntento(int intento)
        {
            // Aquí se cumple la consigna: el contador global se incrementa en "otro método"
            intentosAdivinanza++;

            Console.WriteLine($"Intento #{intentosAdivinanza}");

            if (intento == numeroSecreto)
            {
                Console.WriteLine($"🎉 ¡Correcto! Adivinó en {intentosAdivinanza} intentos.");
                // Dejar numeroSecreto en 0 permite iniciar un nuevo juego la próxima vez que se llame a Ejecutar()
                numeroSecreto = 0;
                return true;
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine(" Incorrecto. Pista: el número secreto es MAYOR.\n");
            }
            else
            {
                Console.WriteLine(" Incorrecto. Pista: el número secreto es MENOR.\n");
            }

            return false;
        }
    }
}
