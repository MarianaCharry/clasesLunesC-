// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

// Definición de la clase Categoria
public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}

// Definición de la clase Producto
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public Categoria Categoria { get; set; }
}

// Clase principal para probar las operaciones
class Program
{
    static List<Categoria> categorias = new List<Categoria>();
    static List<Producto> productos = new List<Producto>();

    // Método para registrar una nueva categoría
    static void RegistrarCategoria(Categoria categoria)
    {
        categoria.Id = categorias.Count + 1;
        categorias.Add(categoria);
        Console.WriteLine("Categoría registrada con éxito.");
    }

    // Método para listar todas las categorías
    static void ListarCategorias()
    {
        Console.WriteLine("Listado de Categorías:");
        foreach (var categoria in categorias)
        {
            Console.WriteLine($"ID: {categoria.Id}, Nombre: {categoria.Nombre}");
        }
    }

    // Método para eliminar una categoría por ID
    static void EliminarCategoria(int id)
    {
        var categoria = categorias.Find(c => c.Id == id);
        if (categoria != null)
        {
            categorias.Remove(categoria);
            Console.WriteLine("Categoría eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró la categoría especificada.");
        }
    }

    // Método para actualizar el nombre de una categoría por ID
    static void ActualizarCategoria(int id, string nuevoNombre)
    {
        var categoria = categorias.Find(c => c.Id == id);
        if (categoria != null)
        {
            categoria.Nombre = nuevoNombre;
            Console.WriteLine("Categoría actualizada correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró la categoría especificada.");
        }
    }

    // Método para registrar un nuevo producto
    static void RegistrarProducto(Producto producto)
    {
        producto.Id = productos.Count + 1;
        productos.Add(producto);
        Console.WriteLine("Producto registrado con éxito.");
    }

    // Método para listar todos los productos
    static void ListarProductos()
    {
        Console.WriteLine("Listado de Productos:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoría: {producto.Categoria.Nombre}");
        }
    }

    // Método para eliminar un producto por ID
    static void EliminarProducto(int id)
    {
        var producto = productos.Find(p => p.Id == id);
        if (producto != null)
        {
            productos.Remove(producto);
            Console.WriteLine("Producto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró el producto especificado.");
        }
    }

    // Método para actualizar el nombre y precio de un producto por ID
    static void ActualizarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
    {
        var producto = productos.Find(p => p.Id == id);
        if (producto != null)
        {
            producto.Nombre = nuevoNombre;
            producto.Precio = nuevoPrecio;
            Console.WriteLine("Producto actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró el producto especificado.");
        }
    }

    static void Main(string[] args)
    {
        // Ejemplo de uso:
        // Registrando categorías
        RegistrarCategoria(new Categoria { Nombre = "Electrónicos" });
        RegistrarCategoria(new Categoria { Nombre = "Ropa" });

        // Registrando productos
        RegistrarProducto(new Producto { Nombre = "Smartphone", Precio = 699.99m, Categoria = categorias[0] });
        RegistrarProducto(new Producto { Nombre = "Camiseta", Precio = 19.99m, Categoria = categorias[1] });

        // Listando categorías y productos
        ListarCategorias();
        ListarProductos();

        // Actualizando una categoría y un producto
        ActualizarCategoria(1, "Dispositivos Electrónicos");
        ActualizarProducto(1, "Nuevo Smartphone", 799.99m);

        // Listando de nuevo para verificar actualizaciones
        ListarCategorias();
        ListarProductos();

        // Eliminando una categoría y un producto
        EliminarCategoria(2);
        EliminarProducto(2);

        // Listando de nuevo para verificar eliminaciones
        ListarCategorias();
        ListarProductos();

        Console.ReadLine();
    }
}
