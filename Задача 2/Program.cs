Console.Write("Write A: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Write B: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("A больше B");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("B больше A");
    }
    else
    {
        Console.WriteLine("A Равно B");
    }
}