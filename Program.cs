using System;

class Program
{
   const int CAPACIDAD = 100;
 static string[] codigos = new string[CAPACIDAD];
    static string[] nombres = new string[CAPACIDAD];
    static double[] precios = new double[CAPACIDAD];
    static int[] stocks = new int[CAPACIDAD];

    // Cantidad actual de productos registrados
    static int cantidad = 0;

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== INVENTARIO DE TIENDA =====");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Mostrar todos los productos");
            Console.WriteLine("3. Buscar producto por código");
            Console.WriteLine("4. Modificar producto");
            Console.WriteLine("5. Insertar producto en posición específica");
            Console.WriteLine("6. Eliminar producto");
            Console.WriteLine("7. Ordenar productos por precio (burbuja)");
            Console.WriteLine("8. Mostrar resumen");
            Console.WriteLine("9. Salir");
            Console.Write("Elige una opción: ");

         opcion = Console.ReadLine();

            switch (opcion)
            {
                case 1: RegistrarProducto(); break;
                case 2: MostrarTodos(); break;
                case 3: BuscarPorCodigo(); break;
                case 4: ModificarProducto(); break;
                case 5: InsertarEnPosicion(); break;
                case 6: EliminarProducto(); break;
                case 7: OrdenarBurbuja(); break;
                case 8: MostrarResumen(); break;
                case 9: Console.WriteLine("Saliendo del sistema..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 9);
    }

    // Aquí irán las funciones de cada integrante
}