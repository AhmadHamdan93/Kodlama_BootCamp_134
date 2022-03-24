// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a = 0;
Console.WriteLine("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("c = ");
int c = Convert.ToInt32(Console.ReadLine());

int delta = b * b - 4 * c;
Console.WriteLine($"delta = {delta}");