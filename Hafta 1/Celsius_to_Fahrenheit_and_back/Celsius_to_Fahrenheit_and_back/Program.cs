// See https://aka.ms/new-console-template for more information

// in this code , i will convert Celsius to Fahrenheit and convert Fahrenheit to Celsius 
//
//  Celsius to Fahrenheit Formula: (°C * 1.8) + 32 = °F
//  Fahrenheit to Celsius Formula: (°F - 32) / 1.8 = °C

double C, F;
string sembol ="";
do
{
    Console.WriteLine("Enter sembol 'f' or 'c' to determine current temperature unit ");
    sembol = Console.ReadLine(); 
} while ((sembol?.Equals("f") == false) && (sembol?.Equals("c") == false));


//if sembol is 'f' that mean convert f to c
// or convert  c to f
try
{
    if (sembol == "f")
    {
        Console.WriteLine("Please Enter Temperature Degree in Fahrenheit");
        F = Convert.ToDouble(Console.ReadLine());
        C = (F - 32) / 1.8;
        Console.WriteLine($"The temperature in Celsius is {C}");
    }
    else
    {
        Console.WriteLine("Please Enter Temperature Degree in Celsius");
        C = Convert.ToDouble(Console.ReadLine());
        F = (C * 1.8) + 32;
        Console.WriteLine($"The temperature in Fahrenheit is {F}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please just Enter digit");
}


