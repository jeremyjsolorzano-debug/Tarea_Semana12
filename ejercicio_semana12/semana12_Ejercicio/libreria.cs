using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana12_Ejercicio
{
    internal class libreria
    {
        string[] Nombre = new string[0];
        double[] Precios = new double[0];
        int pos = 0;

        public void Registrar()
        {
            Console.Clear();
            string nombre;
            double precio;

            while (true)
            {

                Console.Write("Ingrese el nombre de un libro: ");
                nombre = Console.ReadLine();

                if (nombre == "")
                {
                    Console.WriteLine("¡No se permite nombres vacíos o nulos!");
                    continue;
                }

                bool repetido = false;
                for (int i = 0; i < Nombre.Length; i++)
                {
                    if (Nombre[i] == nombre)
                    {
                        repetido = true;
                        break;
                    }

                }

                if (repetido)
                {
                    Console.WriteLine("ya hay un libro con ese nombre.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("\nIngrese el precio del libro: S/. ");
                if (double.TryParse(Console.ReadLine(), out precio) & precio >= 0 && precio <= 1000) break;
                else Console.WriteLine("ingrese un precio real\n");
            }

            Array.Resize(ref Nombre, Nombre.Length + 1);
            Array.Resize(ref Precios, Precios.Length + 1);
            Nombre[pos] = nombre;
            Precios[pos] = precio;
            pos++;

            Console.WriteLine("\nEl libro se registro correctamente. ");
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine(" Libros       Precios");

            if (Nombre.Length == 0)
            {
                Console.WriteLine("\nNo hay libros registrados. ");
                return;
            }

            for (int i = 0; i < Precios.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Nombre[i]}    -   S/. {Precios[i]} ");
            }
        }

        public void Modificar()
        {
            Console.Clear();
            if (Nombre.Length == 0)
            {
                Console.WriteLine("No hay ningun libro registrado para modificarlo");
                return;
            }

            Console.Write("\nIngrese el nombre del libro a modificar: ");
            string nombreBuscar = Console.ReadLine();
            int Índice = -1;


            for (int i = 0; i < Nombre.Length; i++)
            {
                if (Nombre[i] == nombreBuscar)
                {
                    Índice = i;
                    break;
                }

            }

            if (Índice == -1)
            {
                Console.WriteLine("\nNo se encontró un libro con ese nombre. ");

                return;
            }

            Console.WriteLine($"\nLibro encontrado: {Nombre[Índice]} - S/. {Precios[Índice]}");

            string NuevoNombre;
            while (true)
            {
                Console.Write("\nIngrese el nuevo nombre del libro: ");
                NuevoNombre = Console.ReadLine();

                if (NuevoNombre == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío o nulo");
                    continue;
                }

                bool repetido = false;
                for (int i = 0; i < Nombre.Length; i++)
                {
                    if (Nombre[i] == NuevoNombre && i != Índice)
                    {
                        repetido = true;
                        break;
                    }
                }

                if (repetido)
                {
                    Console.WriteLine("nombre del libro existente.");
                    continue;
                }
                break;
            }

            double NuevoPrecio;
            while (true)
            {
                Console.Write("Ingrese el nuevo precio del libro: S/. ");
                if (double.TryParse(Console.ReadLine(), out NuevoPrecio) & NuevoPrecio >= 0 && NuevoPrecio <= 1000)
                    break;
                else Console.WriteLine("Ingrese un precio válido (0 - 1000)");
            }


            Nombre[Índice] = NuevoNombre;
            Precios[Índice] = NuevoPrecio;

            Console.WriteLine("\nEl libro ha sido modificado.");
        }

        public void Eliminar()
        {
            Console.Clear();

            if (Nombre.Length == 0)
            {
                Console.WriteLine("No hay libros registrados para eliminar");
                return;
            }

            int indice = -1;
            Console.Write("\nIngrese el nombre del libro a eliminar: ");
            string nombreEliminar = Console.ReadLine();

            for (int i = 0; i < Nombre.Length; i++)
            {
                if (Nombre[i] == nombreEliminar)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                for (int j = indice; j < Nombre.Length - 1; j++)
                {
                    Nombre[j] = Nombre[j + 1];
                    Precios[j] = Precios[j + 1];
                }

                Array.Resize(ref Nombre, Nombre.Length - 1);
                Array.Resize(ref Precios, Precios.Length - 1);
                pos--;
                Console.WriteLine($"\nEl libro \"{nombreEliminar}\" fue eliminado.");
            }
            else Console.WriteLine("\nEste libro no existe, Por lo tanto no se puede eliminar. ");
        }
    }
}
