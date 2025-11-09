using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana12_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            libreria e = new libreria();


            do
            {
                Console.Clear();
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("|        SISTEMA DE REGISTROS DE LIBROS         |");
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("****             Menú de opciones:          ****\n");
                Console.WriteLine(" 1. Registrar ");
                Console.WriteLine(" 2. Mostrar ");
                Console.WriteLine(" 3. Modificar ");
                Console.WriteLine(" 4. Eliminar ");
                Console.WriteLine(" 0. Salir\n ");

                int opc;

                while (true)
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) & opc >= 0 && opc <= 4) break;
                    else Console.WriteLine("ingrese una opcion valida\n");
                }

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("vuelva pronto.");
                        return;
                    case 1: e.Registrar(); break;
                    case 2: e.Mostrar(); break;
                    case 3: e.Modificar(); break;
                    case 4: e.Eliminar(); break;
                }

                while (true)
                {
                    Console.Write("\nDesea continuar? [S/N] : ");
                    continuar = Console.ReadLine().ToUpper();
                    if (continuar == "S" || continuar == "N") break;
                    else Console.WriteLine("solo se puede ingresar 's' o 'n'.\n");
                }
                Console.WriteLine("\nGracias por utilizar el sistema. ");

            } while (continuar == "S");
        }
    }
}
