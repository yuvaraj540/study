Console.WriteLine("Enter a E-Mail : ");
string? email = Console.ReadLine();

if (string.IsNullOrWhiteSpace(email))
{
    Console.WriteLine("Email is not valid");
    return;
}

if(email.Contains('@') && email.Contains('.') && !email.StartsWith('@') && !email.EndsWith('@'))
{
    if(email.IndexOf('@') < email.IndexOf('.')){
        Console.WriteLine("Email is valid");
    }
    else{
        Console.WriteLine("Email is not valid");
    }
}
else{
        Console.WriteLine("Email is not valid");
}
