// See https://aka.ms/new-console-template for more information

int a = 0;
Console.WriteLine("a = ");
try {
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("b = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("c = ");
    int c = Convert.ToInt32(Console.ReadLine());
    int delta = b * b - 4 * c;
    Console.WriteLine($"delta = {delta}");
}
catch(FormatException) {
    Console.WriteLine("Please just Enter Number");
}   


