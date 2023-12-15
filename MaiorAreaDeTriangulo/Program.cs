// See https://aka.ms/new-console-template for more information
using MaiorAreaDeTriangulo;

Console.WriteLine("Maior área do tringulo!!");

Triangulo X, Y;

X= new Triangulo();
Y= new Triangulo();

Console.WriteLine("Entre com as medidas do tringulo X");

X.A = double.Parse(Console.ReadLine());
X.B = double.Parse(Console.ReadLine());
X.C = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do tringulo Y");

Y.A = double.Parse(Console.ReadLine());
Y.B = double.Parse(Console.ReadLine());
Y.C = double.Parse(Console.ReadLine());


double areax = X.Area();


double areay = Y.Area();

Console.WriteLine("Área de X = " + areax.ToString("F4"));
Console.WriteLine("Área de Y = " + areay.ToString("F4"));

if (areax > areay)
{
    Console.WriteLine("Maior area = X");
}
else
{
    Console.WriteLine("Maior área = Y");
}