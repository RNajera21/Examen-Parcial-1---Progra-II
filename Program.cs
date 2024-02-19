internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {

            int n = 1;
            int medicamento = n;
            int menu = 0;
            int edad = 0;
            int edad1 = 0;
            int edad2 = 0;
            int edad3 = 0;
            int edad4 = 0;
            bool nums = false;
            bool salir = false;

            string tipodesangre = "";
            string[] nombpaciente = new string[n];
            string[] nomMeds = new string[100];
            object[,] infopacientes = new object[100, 5];
            object[,] medicamentos = new object[100, 3];
            object[,] tratamientos = new object[100, 3];

            while (!salir)
            {
                Console.WriteLine("**Sistema de Gestión de Pacientes y Consultas Médicas**");
                Console.WriteLine("0 - Menú principal");
                Console.WriteLine("1 - Agregar paciente");
                Console.WriteLine("2 - Agregar medicamento al catálogo");
                Console.WriteLine("3 - Asignar tratamiento médico a un paciente");
                Console.WriteLine("4 - Consultar el sistema");
                Console.WriteLine("5 - Salir");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 0:


                        Console.WriteLine("**Sistema de Gestión de Pacientes y Consultas Médicas**");
                        Console.WriteLine("0 - Menú principal");
                        Console.WriteLine("1 - Agregar paciente");
                        Console.WriteLine("2 - Agregar medicamento al catálogo");
                        Console.WriteLine("3 - Asignar tratamiento médico a un paciente");
                        Console.WriteLine("4 - Consultar el sistema");
                        Console.WriteLine("5 - Salir");
                        menu = int.Parse(Console.ReadLine());
                        break;

                    case 1:

                        Console.WriteLine("Agregar paciente");
                        for (int i = 0; i < n; i++)
                        {
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese la cédula del Paciente " + (i + 1));
                                    infopacientes[i, 0] = int.Parse(Console.ReadLine());
                                    nums = false;
                                }
                                catch
                                {
                                    Console.WriteLine("------Este campo solo acepta dígitos------");
                                    nums = true;
                                }
                            } while (nums);

                            //Ciclo de recoleccion de nombre
                            Console.WriteLine("Nombre del Paciente  " + (i + 1));
                            infopacientes[i, 3] = Console.ReadLine();
                            infopacientes[i, 3] = nombpaciente[i];
                            nombpaciente[i] += 1;

                            //Ciclo recoleccion telefono
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Teléfono del paciente: " + (i + 1));
                                    infopacientes[i, 2] = Console.ReadLine();
                                    nums = false;
                                }
                                catch
                                {
                                    Console.WriteLine("------Este campo solo acepta dígitos------");
                                    nums = true;
                                }
                            } while (nums);

                            //Tipo  Sangre
                            Console.WriteLine("Tipo de Sangre: ");
                            infopacientes[i, 3] = Console.ReadLine();
                            infopacientes[i, 3] = tipodesangre;

                            //Direccion
                            Console.WriteLine("Ingrese la direccion");
                            infopacientes[i, 4] = Console.ReadLine();

                            //Fecha de Nacimiento
                            Console.WriteLine("Ingrese la fecha de nacimiento en formato YYYY-MM-DD");
                            string fechaNacimientoString = Console.ReadLine();
                            string[] partesFecha = fechaNacimientoString.Split('-');
                            int añoNacimiento = int.Parse(partesFecha[0]);
                            int mesNacimiento = int.Parse(partesFecha[1]);
                            int diaNacimiento = int.Parse(partesFecha[2]);

                            // Obtener la fecha actual
                            DateTime fechaActual = DateTime.Today;
                            int añoActual = fechaActual.Year;
                            int mesActual = fechaActual.Month;
                            int diaActual = fechaActual.Day;
                            // Calcular la edad
                            edad = añoActual - añoNacimiento;
                            if (edad <= 10)
                            {
                                edad1++;
                            }
                            if (edad >= 11 && edad <= 30)
                            {
                                edad2++;
                            }
                            if (edad >= 31 && edad <= 50)
                            {
                                edad3++;
                            }
                            if (edad >= 51)
                            {
                                edad4++;
                            }

                            Console.WriteLine("¿Desea ingresar información de otro Paciente? (S/N): ");
                            string continuar = Console.ReadLine();
                            if (continuar.ToUpper() != "S")
                            {
                                break;
                            }
                        }
                        break;



                    case 2:
                        //Agregar valores al arreglo de medicamentos
                        Console.WriteLine("Agregar medicamento al catálogo");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Ingrese el código del medicamento:");
                            medicamentos[i, 0] = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del medicamento:");
                            medicamentos[i, 1] = Console.ReadLine();
                            Console.WriteLine("Ingrese la cantidad en inventario:");
                            medicamentos[i, 2] = Console.ReadLine();

                        }
                        break;

                    case 3:
                        // Asignacion de tratamientos
                        Console.WriteLine("Asignar tratamiento médico a un paciente");
                        Console.WriteLine("A cuál paciente le desea asignar el tratamiento?");//Falta recorrer el arreglo de pacientes.
                        break;

                    case 4:

                        Console.WriteLine("Menú de consultas");
                        Console.WriteLine("La cantidad total de pacientes registrados es: " + n);
                        Console.WriteLine("Los medicamentos recetados son: ");//Falta asignar med a pacientes
                        Console.WriteLine("La cantidad de pacientes entre las edades de 0-10 años son:" + edad1);
                        Console.WriteLine("La cantidad de pacientes entre las edades de 11-30 años son:" + edad2);
                        Console.WriteLine("La cantidad de pacientes entre las edades de 31-50 años son:" + edad3);
                        Console.WriteLine("La cantidad de pacientes de mas de 51 años son:  " + edad4);
                        for (int i = 0; i < nombpaciente.Length; i++)
                        {
                            Console.WriteLine("Los Pacientes en el sistema son:" + infopacientes[0, 3]);
                        }

                        break;

                    case 5:

                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 5.");
                        break;
                }
            }
        }
    }
}