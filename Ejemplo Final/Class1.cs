﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string[] productos = new string[100];
    static double[] precios = new double[100];
    static int[] cantidades = new int[100];
    static int contadorProductos = 0;

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
                    AgregarProducto();
                    break;
                case "2":
                    // Implementar la lógica para eliminar producto aquí
                    EliminarProducto();

                    break;
                case "3":
                    // Implementar la lógica para modificar producto aquí
                    ModificarProducto();
                    break;
                case "4":
                    // Implementar la lógica para mostrar inventario aquí
                    MostrarInventario();
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
    static void EliminarProducto()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Eliminar Producto =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Ingrese el nombre del producto a eliminar:");
        string nombre = Console.ReadLine();

        int indice = Array.IndexOf(productos, nombre);

        if (indice != -1)
        {
            for (int i = indice; i < contadorProductos - 1; i++)
            {
                productos[i] = productos[i + 1];
                precios[i] = precios[i + 1];
                cantidades[i] = cantidades[i + 1];
            }

            contadorProductos--;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Confirmación: Producto eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Error: El producto no existe.");
        }

        Console.ReadLine();
    }
    static void ModificarProducto()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Modificar Producto =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Ingrese el nombre del producto a modificar:");
        string nombre = Console.ReadLine();

        int indice = Array.IndexOf(productos, nombre);

        if (indice != -1)
        {
            Console.WriteLine("Ingrese el nuevo precio:");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva cantidad:");
            int cantidad = int.Parse(Console.ReadLine());

            precios[indice] = precio;
            cantidades[indice] = cantidad;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Confirmación: Producto modificado exitosamente.");
        }
        else
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Error: El producto no existe.");
        }

        Console.ReadLine();
    }
    static void MostrarInventario()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Mostrar Inventario =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Inventario Actual:");

        for (int i = 0; i < contadorProductos; i++)
        {
            Console.WriteLine($"Producto {i + 1}: {productos[i]} - Precio: ${precios[i]} - Cantidad: {cantidades[i]}");
        }

        Console.ReadLine();
    }


    static void GestionarAlmacenes()
    {
        // Implementar la lógica para gestionar almacenes aquí
    }
    static void GestionarAlmacenes()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("||       Gestionar Almacenes - Mi Tiendita      ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|| 1. Agregar Almacén                           ||");
            Console.WriteLine("|| 2. Eliminar Almacén                          ||");
            Console.WriteLine("|| 3. Mostrar Almacenes                         ||");
            Console.WriteLine("|| 4. Volver al Menú Principal                  ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Seleccione una opción:");

            int opcionAlmacenes = int.Parse(Console.ReadLine());

            switch (opcionAlmacenes)
            {
                case 1:
                   
                    break;
                case 2:
                   
                    break;
                case 3:
                    
                    break;
                default:
                    volver = true;
                    break;
            }
        }
    }
    static void AgregarAlmacen()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Agregar Almacén =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Ingrese el nombre del nuevo almacén:");
        string nombre = Console.ReadLine();

        almacenes[contadorAlmacenes] = nombre;
        contadorAlmacenes++;

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Confirmación: Almacén agregado exitosamente.");
        Console.ReadLine();
    }
    static void EliminarAlmacen()
    {
        Console.Clear();
        Console.WriteLine("===== Pantalla para Eliminar Almacén =====");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Ingrese el nombre del almacén a eliminar:");
        string nombre = Console.ReadLine();

        int indice = Array.IndexOf(almacenes, nombre);

        if (indice != -1)
        {
            for (int i = indice; i < contadorAlmacenes - 1; i++)
            {
                almacenes[i] = almacenes[i + 1];
            }

            contadorAlmacenes--;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Confirmación: Almacén eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Error: El almacén no existe.");
        }

        Console.ReadLine();
    }

}

