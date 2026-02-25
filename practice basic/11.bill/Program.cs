Console.WriteLine("Enter a Product 1 Price : ");
bool p1 = int.TryParse(Console.ReadLine(),out int product1);
Console.WriteLine("Enter a Product 2 Price : ");
bool p2 = int.TryParse(Console.ReadLine(),out int product2);
Console.WriteLine("Enter a Product 3 Price : ");
bool p3 = int.TryParse(Console.ReadLine(),out int product3);

if(p1 && p2 && p3)
{
    double Total = product1 + product2 + product3;
    double discount = 0.0;

    if (Total > 5000)
    {
        discount = Total * (10.0/100.0); // 10% discount
        Console.WriteLine(discount);
    }
    double FinalAmount = Total - discount;
    Console.WriteLine($"Total: {Total} \nDiscount: {discount} \nFinal Amount: {FinalAmount}");
    
}
else
{
    Console.WriteLine("Invalid Input....");
    return;
}
