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
            while (!int.TryParse(Console.ReadLine(), out opcion)) // con el tryparse por si el usuario ingresa algo que no es número
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        private static void AgregarProductoCarrito() 
        {
            double precio; // Variable local para el precio del producto
            Console.Write("Precio del producto: $");
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0) // Validación de que sea positivo
            {
                Console.Write("Ingrese un precio válido: $"); // en caso de que no lo sea
            }
            
            carritoTotal += precio; // aca ya se le suma al total del carrito
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
            
            if (precio <= carritoTotal) // esta condición es para que no quede negativo el total del carrito
            {
                carritoTotal -= precio; // aca se le resta al total del carrito para eliminar el ultimo producto
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
