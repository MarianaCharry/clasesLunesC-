// See https://aka.ms/new-console-template for more information
using trabajoClases.models;

Console.WriteLine("Bienvenido a Mayaya´s");

class Program
{
    // Lista para almacenar las categorías
    static List<categoria> listaCategorias = new List<categoria>();

    // Método para registrar una nueva categoría
    static void RegistrarCategoria()
    {
        Console.WriteLine("Ingrese el ID de la categoría:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre de la categoría:");
        string nombre = Console.ReadLine();

        categoria nuevaCategoria = new categoria(id, nombre);
        listaCategorias.Add(nuevaCategoria);

        Console.WriteLine("Categoría registrada exitosamente.");
    }

    // Método para listar todas las categorías registradas
    static void ListarCategorias()
    {
        Console.WriteLine("Lista de categorías:");
        foreach (var categoria in listaCategorias)
        {
            Console.WriteLine($"ID: {categoria.Id}, Nombre: {categoria.Nombre}");
        }
    }

    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Registrar nueva categoría");
            Console.WriteLine("2. Listar categorías");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarCategoria();
                    break;
                case "2":
                    ListarCategorias();
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine(); // Salto de línea para separar las iteraciones del menú

        } while (opcion != "3");
    }
}

