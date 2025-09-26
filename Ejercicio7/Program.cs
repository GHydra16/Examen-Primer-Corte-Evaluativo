// Descripción: 7. Simulador de Tienda en Línea
//• Declara una variable global carritoTotal.
//• Crea métodos con variables locales para:
//✓ Agregar un producto (sumando su precio al total).
//✓ Eliminar un producto.
//✓ Consultar el total actual de la compra.
 
using System;

namespace evaluacion // namespace cambiado para evitar conflictos
{
    public static class Evaluacion7_SimuladorTiendaLinea
    {
        // Variable global para el total del carrito
        private static double carritoTotal = 0; //Variable global para el total del carrito

        public static void Ejecutar()
        {   // Menú principal
            Console.WriteLine("\n=== EVALUACIÓN 7: SIMULADOR DE TIENDA EN LÍNEA ===");
            Console.WriteLine($"Total del carrito: ${carritoTotal:F2}");
            Console.WriteLine("\n1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Consultar total");
            Console.Write("Seleccione una opción: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion) // Llamada a los métodos según la opción seleccionada
            {
                case 1:
                    AgregarProductoCarrito(); 
                    break;
                case 2:
                    EliminarProductoCarrito();
                    break;
                case 3:
                    ConsultarTotalCarrito();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
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

        private static void AgregarProductoCarrito()
        {
            double precio;
            Console.Write("Precio del producto: $");
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.Write("Ingrese un precio válido: $");
            }
            
            carritoTotal += precio;
            Console.WriteLine($"Producto agregado. Total del carrito: ${carritoTotal:F2}");
        }

        private static void EliminarProductoCarrito()
        {
            double precio;
            Console.Write("Precio del producto a eliminar: $");
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.Write("Ingrese un precio válido: $");
            }
            
            if (precio <= carritoTotal)
            {
                carritoTotal -= precio;
                Console.WriteLine($"Producto eliminado. Total del carrito: ${carritoTotal:F2}");
            }
            else
            {
                Console.WriteLine("El precio a eliminar excede el total del carrito.");
            }
        }

        private static void ConsultarTotalCarrito()
        {
            Console.WriteLine($"Total actual del carrito: ${carritoTotal:F2}");
        }
    }
}
