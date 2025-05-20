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

Console.WriteLine("Ingrese un cadena");
string cad = Console.ReadLine();
Console.WriteLine("Longitud; " + cad.Length);

Console.WriteLine("Ingrese otra cadena");

string cad2 = Console.ReadLine();
Console.WriteLine(cad2.Substring(2));

foreach (char c in cad)
{
    Console.WriteLine(c);
}

Console.WriteLine(cad.ToUpper());
Console.WriteLine(cad.ToLower());

if (cad.Contains(Console.ReadLine()))
{
    Console.WriteLine("Contiene la palabra");
}

string cad3 = Console.ReadLine();

string[] subs = cad3.Split(' ');
foreach (var sub in subs)
{
    Console.WriteLine($"substring {sub}");
}