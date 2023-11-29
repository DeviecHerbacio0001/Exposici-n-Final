using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||     Sistema de Inventario \"Mi Tiendita\"      ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("||   1. Gestionar Productos                     ||");
            Console.WriteLine("||   2. Gestionar Almacenes                     ||");
            Console.WriteLine("||   3. Agregar y Extraer Productos             ||");
            Console.WriteLine("==================================================");
            Console.Write("Seleccione una opción y presione Enter: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    GestionarProductos();
                    break;
                case "2":
                    GestionarAlmacenes();
                    break;
                case "3":
                    AgregarYExtraerProductos();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void GestionarProductos()
    {
        while (true)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||   Gestionar Productos - Mi Tiendita          ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("||   1. Agregar Producto                        ||");
            Console.WriteLine("||   2. Eliminar Producto                       ||");
            Console.WriteLine("||   3. Modificar Producto                      ||");
            Console.WriteLine("||   4. Mostrar Inventario                      ||");
            Console.WriteLine("||   5. Volver al Menú Principal                ||");
            Console.WriteLine("==================================================");
            Console.Write("Seleccione una opción y presione Enter: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Implementar la lógica para agregar producto aquí
                    break;
                case "2":
                    // Implementar la lógica para eliminar producto aquí
                    break;
                case "3":
                    // Implementar la lógica para modificar producto aquí
                    break;
                case "4":
                    // Implementar la lógica para mostrar inventario aquí
                    break;
                case "5":
                    // Salir del menú de gestión de productos
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
    static void AgregarYExtraerProductos()
    {
        // Implementar la lógica para agregar y extraer productos aquí
    }
    static void AgregarProducto()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Agregar Producto =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el precio del producto:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad del producto:");
        int cantidad = int.Parse(Console.ReadLine());

        productos[contadorProductos] = nombre;
        precios[contadorProductos] = precio;
        cantidades[contadorProductos] = cantidad;
        contadorProductos++;

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Confirmación: Producto agregado exitosamente.");
        Console.ReadLine();
    }

    static void GestionarAlmacenes()
    {
        // Implementar la lógica para gestionar almacenes aquí
    }

   
} 

