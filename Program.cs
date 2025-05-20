// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a="+a);
Console.WriteLine("Valor de b=" + b);


string? n = Console.ReadLine();
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