using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libros_ejer
{
    internal class Program
    {


        //creamos vectores donde se guardara la informacion
        static string[] titulos = new string[100];
        static string[] isbns = new string[100];
        static int[] ediciones = new int[100];
        static string[] autores = new string[100];
        static int[] codigos = new int[100];

        static int contadorLibros = 0;

        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear(); // Limpia la consola antes de mostrar el menú

                Console.WriteLine("Bienvenido a la biblioteca");
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Mostrar listado de libros");
                Console.WriteLine("3. Buscar libro por código");
                Console.WriteLine("4. Editar información de un libro por código");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;

                    case 2:
                        MostrarListado();
                        break;

                    case 3:
                        BuscarPorCodigo();
                        break;

                    case 4:
                        EditarPorCodigo();
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione Enter para volver al menú...");
                    Console.ReadLine();
                }
            }
        }

        static void AgregarLibro()
        {
            if (contadorLibros < codigos.Length)
            {
                Console.Clear(); // Limpia la consola antes de agregar un libro

                Console.Write("Código del libro: ");
                int codigo = int.Parse(Console.ReadLine());
                codigos[contadorLibros] = codigo;

                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                titulos[contadorLibros] = titulo;

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                isbns[contadorLibros] = isbn;

                Console.Write("Edición: ");
                int edicion = int.Parse(Console.ReadLine());
                ediciones[contadorLibros] = edicion;

                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                autores[contadorLibros] = autor;

                contadorLibros++;

                Console.WriteLine("\nLibro agregado correctamente.");
            }
            else
            {
                Console.Clear(); // Limpia la consola antes de mostrar el mensaje de biblioteca llena
                Console.WriteLine("La biblioteca está llena. No es posible agregar más libros.");
            }
        }

        static void MostrarListado()
        {
            Console.Clear(); // Limpia la consola antes de mostrar el listado
            Console.WriteLine("Listado de libros:");

            for (int i = 0; i < contadorLibros; i++)
            {
                Console.WriteLine($"Código: {codigos[i]}");
                Console.WriteLine($"Título: {titulos[i]}");
                Console.WriteLine($"ISBN: {isbns[i]}");
                Console.WriteLine($"Edición: {ediciones[i]}");
                Console.WriteLine($"Autor: {autores[i]}");
                Console.WriteLine();
            }
        }

        static void BuscarPorCodigo()
        {
            Console.Clear(); // Limpia la consola antes de buscar un libro
            Console.Write("Ingrese el código del libro a buscar: ");
            int codigoBuscado = int.Parse(Console.ReadLine());

            for (int i = 0; i < contadorLibros; i++)
            {
                if (codigos[i] == codigoBuscado)
                {
                    Console.WriteLine("Información del libro encontrado:");
                    Console.WriteLine($"Código: {codigos[i]}");
                    Console.WriteLine($"Título: {titulos[i]}");
                    Console.WriteLine($"ISBN: {isbns[i]}");
                    Console.WriteLine($"Edición: {ediciones[i]}");
                    Console.WriteLine($"Autor: {autores[i]}");
                    return; // Salir del método una vez encontrado el libro
                }
            }

            Console.WriteLine("Libro no encontrado.");
        }

        static void EditarPorCodigo()
        {
            Console.Clear(); // Limpia la consola antes de editar un libro
            Console.Write("Ingrese el código del libro a editar: ");
            int codigoBuscado = int.Parse(Console.ReadLine());

            for (int i = 0; i < contadorLibros; i++)
            {
                if (codigos[i] == codigoBuscado)
                {
                    Console.WriteLine("Información actual del libro:");
                    Console.WriteLine($"Código: {codigos[i]}");
                    Console.WriteLine($"Título: {titulos[i]}");
                    Console.WriteLine($"ISBN: {isbns[i]}");
                    Console.WriteLine($"Edición: {ediciones[i]}");
                    Console.WriteLine($"Autor: {autores[i]}");

                    Console.WriteLine("Ingrese la nueva información:");

                    Console.Write("Nuevo título: ");
                    string nuevoTitulo = Console.ReadLine();
                    titulos[i] = nuevoTitulo;

                    Console.Write("Nuevo ISBN: ");
                    string nuevoISBN = Console.ReadLine();
                    isbns[i] = nuevoISBN;

                    Console.Write("Nueva edición: ");
                    int nuevaEdicion = int.Parse(Console.ReadLine());
                    ediciones[i] = nuevaEdicion;

                    Console.Write("Nuevo autor: ");
                    string nuevoAutor = Console.ReadLine();
                    autores[i] = nuevoAutor;

                    Console.WriteLine("\nLibro editado correctamente.");
                    return; // Salir del método una vez editado el libro
                }
            }

            Console.WriteLine("Libro no encontrado.");
        }
    }
}


