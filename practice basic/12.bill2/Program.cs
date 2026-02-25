Console.WriteLine("Enter a Units : ");
bool input = double.TryParse(Console.ReadLine(),out double units);

if (input)
{
    double bill = 0.0;
    if (units > 300)
    {
        bill = (100 * 1.5) + (200 * 2) + ((units - 300) * 3);
        Console.WriteLine($"Bill Amount is {bill}");
    }
    else if (units > 100)
    {
        bill = (100 * 1.5) + ((units - 100) * 2);
        Console.WriteLine($"Bill Amount is {bill}");
    }
    else
    {
        bill = units * 1.5;
        Console.WriteLine($"Bill Amount is {bill}"); 
    }
}
else
{
    Console.WriteLine("Invalid Input....");
    return;
}
