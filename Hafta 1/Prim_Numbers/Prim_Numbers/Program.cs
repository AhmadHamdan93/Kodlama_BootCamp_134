// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Number :");
int num = 0;
num = Convert.ToInt32(Console.ReadLine());
bool primChecked = true;
for(int i = 2; i < num; i++)
{
    if(num % i == 0)
    {
        primChecked = false;
    }
}
if(primChecked)
    Console.WriteLine($"the number {num} is prim");
else
    Console.WriteLine($"the number {num} is not prim");