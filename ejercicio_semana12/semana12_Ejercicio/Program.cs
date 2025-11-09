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
            string cont;
            libreria e = new libreria();

            do
            {
                Console.Clear();
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("|          REGISTRADORA DE LIBROS               |");
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("**** Menú de opciones:           ****\n");
                Console.WriteLine(" 1. Registrar ");
                Console.WriteLine(" 2. Mostrar ");
                Console.WriteLine(" 3. Modificar ");
                Console.WriteLine(" 4. Eliminar ");
                Console.WriteLine(" 0. Salir\n ");


                int opc = 0;
                bool opcionValida = false;

                do
                {
                    Console.Write("Ingrese una opción: ");

                    string entrada = Console.ReadLine();


                    switch (entrada)
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":

                            opc = int.Parse(entrada);
                            opcionValida = true;
                            break;
                        default:
                            Console.WriteLine("Ingrese la opción correcta\n");
                            break;
                    }

                } while (opcionValida == false);
                switch (opc)
                {
                    case 0:
                        Console.WriteLine("\nvuelva pronto.");
                        return;
                        
                    case 1:
                        e.Registrar();
                        break;
                    case 2:
                        e.Mostrar();
                        break;
                    case 3:
                        e.Modificar();
                        break;
                    case 4:
                        e.Eliminar();
                        break;

                }

                while (true)
                {
                    Console.WriteLine("\n¿Desea continuar? [S/N] : ");
                    cont = Console.ReadLine().ToUpper();
                    if (cont == "S" || cont == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("solo se puede ingresar: 's' o 'n'.\n");
                    }
                }
            } while (cont == "S");

            Console.WriteLine("\nGracias por utilizar nuestro sistema. ");
        }
    }
}
