Console.WriteLine("Enter a Number");
int x = Int32.Parse(Console.ReadLine());

if(x == 0){
    Console.WriteLine($"The Number {x} is Zero");
}
else if(x > 0){
    Console.WriteLine($"The NUmbe {x} is Positive");
}
else{
    Console.WriteLine($"The NUmbe {x} is Negative");    
}
