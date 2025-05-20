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
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("\tabs");
    Console.WriteLine("\tCuadrado");
    Console.WriteLine("\tRaiz");
    Console.WriteLine("\tseno");
    Console.WriteLine("\tcoseno");
    Console.WriteLine("\tParte entera");
    Console.WriteLine("\tMin");
    Console.WriteLine("\tMax");
    Console.WriteLine("\tSalir");
    op = Console.ReadLine();
    
    if (op == "Salir")
    {
        break;
    }
    int x = 0;
    int y = 0;
    float z = 0;
    bool res;
    if (op == "Max" || op == "Min")
    {
        Console.WriteLine("Ingrese 2 numeros");
        res = int.TryParse(Console.ReadLine(), out x) && int.TryParse(Console.ReadLine(), out y);
    }
    else
    {
        Console.WriteLine("Ingrese 1 numero");
    
        res = float.TryParse(Console.ReadLine(), out z);
    }
    if (res) {
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
            case "abs":
                Console.WriteLine(Math.Abs(z));
                break;
            case "Cuadrado":
                Console.WriteLine(float.Pow(z, 2));
                break;
            case "Raiz":
                Console.WriteLine(float.Sqrt(z));
                break;
            case "seno":
                Console.WriteLine(float.Sin(z));
                break;
            case "coseno":
                Console.WriteLine(float.Cos(z));
                break;
            case "Parte entera":
                Console.WriteLine(Math.Truncate(z));
                break;
            case "Max":
                Console.WriteLine(int.Max(x, y));
                break;
            case "Min":
                Console.WriteLine(int.Min(x, y));
                break;

        }
    }
}