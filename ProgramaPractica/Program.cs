/*
   Hacer un programa que le pida al usuario su nombre
    y su apellido, el nombre y el apellido, guardarlos
    en variables separadas.

    Luego, preguntarle al usuario por su sexo: Femenino (F) o 
    Masculino (M).

    Luego, preguntarle la edad al usuario. Si es menor de 18, decirle que
    no puede usar el sistema. Si tiene 18 años en adelante, darle la 
    darle la bienvenida al usuario. Considera su sexo para decirle:
    Bienvenido o Bienvenida.

    Luego, pidele al usuario llamandolo por su nombre completo, que ingrese
    dos numeros enteros.

    Luego, pidele que te indique que operacion matematica quiere hacer: 
    Presentale las diferentes opciones que son:
    Suma (s) - Resta (r) - Multiplicacion (M) - Division (d)
    Exponente (e)

    Por ultimo: Mostrar en pantalla el resultado final, diciendole:
    Usuario: El resultado de la operacion X es Y
 
 
 
 
 */

using ProgramaPractica.ArchivosProgramaPractica;

Console.Write("Digita tu nombre ");
string name = Console.ReadLine();
Console.Write("Digita tu apellido ");
string lastName = Console.ReadLine();
string fullName = name + " " + lastName;
Console.WriteLine("Indica tu sexo M/F");
char sexo = Convert.ToChar(Console.ReadLine());
if (sexo == 'M' || sexo == 'F')
{
    Console.WriteLine("Digita tu edad");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 18)
    {
        Console.WriteLine("Lo siento, no puedes acceder al sistema");
    }
    else if (age >= 18)
    {
        if (sexo == 'M')
        {
            Console.WriteLine($"Bienvenido al programa");
        }
        else
        {
            Console.WriteLine($"Bienvenida al programa");
        }
    }
    Console.WriteLine("Bienvenidos a la Calculadora Espacial!!!");
}

else
{
    Console.WriteLine("Sexo Invalido (M) (F). Vuelva a iniciar.");
    return;
}
FuncionesCalculadora funcionesCalculadora = new FuncionesCalculadora();

{
    Console.Write($"{fullName} Ingrese el primer número: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write($"{fullName} Ingrese el segundo número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el operador ((S) para suma, (R) para resta, (M) para multiplicar, (D) para división), (p) para Potencia: ");
    char operador = Convert.ToChar(Console.ReadLine());

    int resultado = 0;

    if (operador == 'S')
    {
        resultado = funcionesCalculadora.Sumar(numero1, numero2);
    }
    else if (operador == 'R')
    {
        resultado = funcionesCalculadora.Restar(numero1, numero2);
    }
    else if (operador == 'M')
    {
        resultado = funcionesCalculadora.multiplicar(numero1, numero2);
    }
    else if (operador == 'D')
    {
        resultado = funcionesCalculadora.Division(numero1, numero2);
    }
    else if (operador == 'P')
    {
        resultado = funcionesCalculadora.Potencia(numero1, numero2);
    }
    else
    {
        Console.WriteLine("Operación no válida.");
        return;
    }

    Console.WriteLine($"{fullName} El resultado es: {resultado} ");
}
