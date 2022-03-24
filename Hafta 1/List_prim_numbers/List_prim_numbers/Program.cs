// See https://aka.ms/new-console-template for more information

for (int i = 1; i < 1000; i++)
{
    bool check = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            check = false;
        }
    }
    if (check) { Console.WriteLine($"the number {i} is prim"); }

}

