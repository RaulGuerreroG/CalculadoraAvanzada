using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaPractica.ArchivosProgramaPractica;

namespace ProgramaPractica.ArchivosProgramaPractica
{
    public class CalculadoraEspecial
    {
        public static void Ejecutar()
        {
            string name = "";
            string lastName = "";
            string gender;
            int age = 0;


            do
            {
                Console.Write("Digita tu nombre: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("El nombre no puede estar vacio");
                }

            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("Digita tu apellido: ");
                lastName = Console.ReadLine();
                if (string.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("El apellido no puede estar vacio");
                }

            } while (string.IsNullOrEmpty(lastName));

            string fullName = name.ToUpper() + " " + lastName.ToUpper();
            do
            {
                Console.Write("Selecciona tu sexo M/F ");
                gender = Console.ReadLine();
                gender = gender.ToLower();

                if (gender != "f" && gender != "m")
                {
                    Console.WriteLine("El sexo es incorrecto. Debes seleccionar 'M' o 'F'.");
                }

            } while (gender != "f" && gender != "m");

            do
            {
                Console.Write("Introduce tu edad: ");
                if (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.WriteLine("Edad incorrecta. Debe ser un número mayor que cero.");
                }

            } while (age <= 0);
            if (age < 18)
            {
                Console.WriteLine("No tienes edad suficiente para utilizar este sistema.");
            }
            else if (age >= 18 && gender == "m")
            {
                Console.WriteLine($"Bienvenido {fullName} Esta es la calculadopra especial!");
            }
            else if (age >= 18 && gender == "f")
            {
                Console.WriteLine($"Bienvenida {fullName} Esta es la calculadopra especial!");
            }

            FuncionesCalculadora funcionesCalculadora = new FuncionesCalculadora();

            Console.WriteLine("Bienvenido al programa de operaciones matemáticas");

            int numero1, numero2;

            while (true)
            {
                Console.Write("Por favor ingrese el primer número entero: ");
                if (int.TryParse(Console.ReadLine(), out numero1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            }

            while (true)
            {
                Console.Write("Por favor ingrese el segundo número entero: ");
                if (int.TryParse(Console.ReadLine(), out numero2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            }

            Console.WriteLine("Elija una operación matemática:");
            Console.WriteLine("1. Suma (s)");
            Console.WriteLine("2. Resta (r)");
            Console.WriteLine("3. Multiplicación (m)");
            Console.WriteLine("4. División (d)");
            Console.WriteLine("5. Exponente (e)");

            Console.Write("Ingrese la opción deseada: ");

            char opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int resultado = 0;

            switch (opcion)
            {
                case 's':
                    resultado = funcionesCalculadora.Sumar(numero1, numero2);
                    Console.WriteLine($"{fullName}: El resultado de la operación Suma es {resultado}");
                    break;
                case 'r':
                    resultado = funcionesCalculadora.Restar(numero1, numero2);
                    Console.WriteLine($"{fullName}: El resultado de la operación Resta es {resultado}");
                    break;
                case 'm':
                    resultado = funcionesCalculadora.multiplicar(numero1, numero2);
                    Console.WriteLine($"{fullName}: El resultado de la operación Multiplicación es {resultado}");
                    break;
                case 'd':
                    if (numero2 != 0)
                    {
                        resultado = funcionesCalculadora.Division(numero1, numero2);
                        Console.WriteLine($"{fullName}: El resultado de la operación División es {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;
                case 'e':
                    resultado = funcionesCalculadora.Potencia(numero1, numero2);
                    Console.WriteLine($"Usuario: El resultado de la operación Potencia es {resultado}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
