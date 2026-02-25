Console.WriteLine("Enter your Number:");

if (int.TryParse(Console.ReadLine(), out int y))
{
    Console.WriteLine($"Multiplication Table of {y}");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} x {y} = {i * y}");
    }
}
else
{
    Console.WriteLine("Invalid input!");
}

