using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenniferMata
{
    internal class Program
    {
        static readonly int N = 12;
        static string[] paciente = new string[N];
        static int[] gravedad = new int[N];

        static void IngresarPacientes()
        {
            Boolean asignado = false;
            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == null || paciente[i] == "")
                {
                    Console.WriteLine($"Ingrese el nombre del paciente {i + 1}: ");
                    paciente[i] = Console.ReadLine();
                    Console.WriteLine($"Ingrese la gravedad del paciente (1 a 5) donde 1 es no muy grave : ");
                    gravedad[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Paciente asignado a la camilla [{i + 1}] de manera correcta");
                    asignado = true;
                    break;
                }
            }
            if (!asignado)
            {
                Console.WriteLine("No hay camillas disponibles para asignar al paciente.");
            }
        }
        static void MostrarPacientes()
        {
            Boolean Encontrado = false;
            Console.WriteLine("Digite el nombre del paciente que desea encontrar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nombre)
                {
                    Console.WriteLine($"El paciente {paciente[i]} tiene un nivel de gravedad de {gravedad[i]}");
                    Encontrado = true;
                    break;
                }
            }
            if (Encontrado == false)
            {
                Console.WriteLine("El paciente no fue encontrado.");
            }
        }

        static void modificarGravedad()
        {
            Boolean Encontrado = false;
            Console.WriteLine("Digite el nombre del paciente que desea modificar: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nombre)
                {
                    Console.WriteLine($"El paciente {paciente[i]} tiene un nivel de gravedad de {gravedad[i]}");
                    Console.WriteLine("Ingrese el nuevo nivel de gravedad (1 a 5) donde 1 es poco grave y 5 muy grave: ");
                    gravedad[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El nivel de gravedad del paciente {paciente[i]} ha sido modificado a {gravedad[i]}");
                    Encontrado = true;
                    break;
                }
            }
            if (Encontrado == false)
            {
                Console.WriteLine("El paciente no fue encontrado.");
            }
        }



        static void eliminarPaciente()
        {
            Boolean Encontrado = false;
            Console.WriteLine("Digite el nombre del paciente que desea dar de alta o trasladar: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nombre)
                {
                    paciente[i] = "";
                    gravedad[i] = 0;
                    Console.WriteLine($"El paciente {nombre} fue dado de alta o trasladado. La cama [{i + 1}] ha sido desocupada. ");
                    Encontrado = true;
                    break;
                }
            }
            if (Encontrado == false)
            {
                Console.WriteLine("El paciente no fue encontrado.");
            }
        }
        static void reportePaciente()
        {
            Console.WriteLine("**** REPORTE DE PACIENTES ****");
            for (int i = 0; i < paciente.Length; i++)
            {
                if (!string.IsNullOrEmpty(paciente[i]))
                {
                    Console.WriteLine($"Paciente: {paciente[i]}, Gravedad: {gravedad[i]}");
                }
            }
        }
        static void menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("**** MENU DE PACIENTES ****");
                Console.WriteLine("1. Ingresar paciente");
                Console.WriteLine("2. Mostrar paciente");
                Console.WriteLine("3. Modificar gravedad");
                Console.WriteLine("4. Dar de alta o trasladar paciente");
                Console.WriteLine("5. Reporte de pacientes");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IngresarPacientes();
                        break;
                    case 2:
                        MostrarPacientes();
                        break;
                    case 3:
                        modificarGravedad();
                        break;
                    case 4:
                        eliminarPaciente();
                        break;
                    case 5:
                        reportePaciente();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente nuevamente.");
                        break;
                }
            } while (opcion != 6);
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
