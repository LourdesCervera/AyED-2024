using System;

namespace Matrices
{
    class Program
    {
        static string[,] pochodex = new string[75, 5];
        static int cantidadPochimons = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Pochimones Encontrados: " + cantidadPochimons + "/75");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opción deseada: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarPochimon();
                        break;
                    case 2:
                        AsignarInvestigador();
                        break;
                    case 3:
                        ActualizarNivel();
                        break;
                    case 4:
                        MarcarComoInvestigado();
                        break;
                    case 5:
                        MostrarInformacion();
                        break;
                    case 6:
                        BuscarPorTipo();
                        break;
                    case 7:
                        MostrarPorInvestigador();
                        break;
                    case 8:
                        MostrarPicados();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RegistrarPochimon()
        {
            if (cantidadPochimons < 75)
            {
                Console.Write("Ingrese el nombre del Pochimon: ");
                pochodex[cantidadPochimons, 0] = Console.ReadLine();
                Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                pochodex[cantidadPochimons, 1] = Console.ReadLine();
                Console.Write("Ingrese el nivel del Pochimon: ");
                pochodex[cantidadPochimons, 2] = Console.ReadLine();
                pochodex[cantidadPochimons, 3] = "0";
                pochodex[cantidadPochimons, 4] = "";
                cantidadPochimons++;
            }
            else
            {
                Console.WriteLine("La Pochidex está llena. No se pueden registrar más Pochimons.");
            }
            Console.ReadKey();
        }

        static void AsignarInvestigador()
        {
            Console.Clear();
            Console.WriteLine("Pochimons no investigados:");
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
            Console.WriteLine("|------|------------|-------|-------|");

            for (int i = 0; i < cantidadPochimons; i++)
            {
                if (pochodex[i, 3] == "0")
                {
                    Console.WriteLine((i + 1) + "     | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2]);
                }
            }

            Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
            int filaAsignar = int.Parse(Console.ReadLine()) - 1;
            if (filaAsignar >= 0 && filaAsignar < cantidadPochimons && pochodex[filaAsignar, 3] == "0")
            {
                Console.Write("Ingrese el código del Investigador: ");
                string codigoInvestigador = Console.ReadLine();
                pochodex[filaAsignar, 4] = codigoInvestigador;
                pochodex[filaAsignar, 3] = "1";
            }
            else
            {
                Console.WriteLine("Número de fila inválido o Pochimon ya investigado.");
            }
            Console.ReadKey();
        }

        static void ActualizarNivel()
        {
            Console.Clear();
            Console.WriteLine("Pochimons registrados:");
            Console.WriteLine("| Fila | Nombre     | Nivel |");
            Console.WriteLine("|------|------------|-------|");

            for (int i = 0; i < cantidadPochimons; i++)
            {
                Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 2]);
            }

            Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
            int filaActualizar = int.Parse(Console.ReadLine()) - 1;
            if (filaActualizar >= 0 && filaActualizar < cantidadPochimons)
            {
                Random random = new Random();
                int incremento = random.Next(1, 4);
                int nivelActual = int.Parse(pochodex[filaActualizar, 2]);
                int nuevoNivel = nivelActual + incremento;
                pochodex[filaActualizar, 2] = nuevoNivel.ToString();

                Console.WriteLine($"Nivel actualizado: {pochodex[filaActualizar, 0]} ahora tiene nivel {nuevoNivel}.");
            }
            else
            {
                Console.WriteLine("Número de fila inválido.");
            }
            Console.ReadKey();
        }

        static void MarcarComoInvestigado()
        {
            Console.Clear();
            Console.WriteLine("Pochimons en investigación:");
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");

            for (int i = 0; i < cantidadPochimons; i++)
            {
                if (pochodex[i, 3] == "1")
                {
                    Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2] + "    | " + pochodex[i, 3] + "      | " + pochodex[i, 4]);
                }
            }

            Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
            int filaMarcar = int.Parse(Console.ReadLine()) - 1;
            if (filaMarcar >= 0 && filaMarcar < cantidadPochimons && pochodex[filaMarcar, 3] == "1")
            {
                pochodex[filaMarcar, 3] = "2";
                Console.WriteLine("Pochimon marcado como investigado.");
            }
            else
            {
                Console.WriteLine("Número de fila inválido o Pochimon no está en investigación.");
            }
            Console.ReadKey();
        }

        static void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");

            for (int i = 0; i < cantidadPochimons; i++)
            {
                Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2] + "    | " + pochodex[i, 3] + "      | " + pochodex[i, 4]);
            }
            Console.ReadKey();
        }

        static void BuscarPorTipo()
        {
            Console.Clear();
            Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
            string tipo = Console.ReadLine();
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");
            for (int i = 0; i < cantidadPochimons; i++)
            {
                if (pochodex[i, 1] == tipo)
                {
                    Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2] + "    | " + pochodex[i, 3] + "      | " + pochodex[i, 4]);
                }
            }
            Console.ReadKey();
        }

        static void MostrarPorInvestigador()
        {
            Console.Clear();
            Console.Write("Ingrese el código del Investigador: ");
            string investigador = Console.ReadLine();
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("|------|------------|-------|-------|--------|-----------------------|");
            for (int i = 0; i < cantidadPochimons; i++)
            {
                if (pochodex[i, 4] == investigador)
                {
                    Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2] + "    | " + pochodex[i, 3]);
                }
            }
            Console.ReadKey();
        }

        static void MostrarPicados()
        {
            Console.Clear();
            Console.WriteLine("Pochimons Picados:");
            Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
            Console.WriteLine("|------|------------|-------|-------|");

            for (int i = 0; i < cantidadPochimons; i++)
            {
                if (int.Parse(pochodex[i, 2]) > 30)
                {
                    Console.WriteLine((i + 1) + "    | " + pochodex[i, 0] + "       | " + pochodex[i, 1] + "    | " + pochodex[i, 2]);
                }
            }
            Console.ReadKey();
        }
    }
}