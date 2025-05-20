// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a="+a);
Console.WriteLine("Valor de b=" + b);

Console.WriteLine("Ingrese el numero a invertir");
string n = Console.ReadLine();
string invertido = "";
int i = 0;


if (int.TryParse(n, out i))
{
    if (i > 0)
    {
        for (int j = 0; j < n.Length; j++)
        {
            invertido = invertido + n[n.Length - j - 1];
        }
    }

    Console.WriteLine("El numero invertido es: " + invertido);
}


string op = "";

while (op != "Salir")
{
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("\tSumar");
    Console.WriteLine("\tResta");
    Console.WriteLine("\tMultiplicacion");
    Console.WriteLine("\tDivision");
    Console.WriteLine("\tSalir");
    op = Console.ReadLine();
    
    if (op == "Salir")
    {
        break;
    }
    Console.WriteLine("Ingrese 2 numeros");
    int x = 0;
    int y = 0;
    if(int.TryParse(Console.ReadLine(),out x) && int.TryParse(Console.ReadLine(),out y)){
        switch (op)
        {
            case "Sumar":
                Console.WriteLine(x + y);
                break;
            case "Resta":
                Console.WriteLine(x - y);
                break;
            case "Multiplicacion":
                Console.WriteLine(x * y);
                break;
            case "Division":
                Console.WriteLine(x / y);
                break;
            default:
                break;
        }
    }
}