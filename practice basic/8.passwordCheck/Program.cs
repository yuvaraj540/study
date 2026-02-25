Console.WriteLine("Enter a Password : ");
string? pass = Console.ReadLine();

if(string.IsNullOrWhiteSpace(pass)){
    Console.WriteLine("Invalid Input");
    return;
}

if (pass.Length < 8)
{
    Console.WriteLine("Invalid Length");
    return;
}

int upperCount = 0,lowerCount = 0,numberCount = 0,specialCharacter = 0;

for(int i=0; i < pass.Length; i++){
    if(char.IsUpper(pass[i])){
        upperCount++;
    }
    else if(char.IsLower(pass[i])){
        lowerCount++;
    }
    else if(char.IsDigit(pass[i])){
        numberCount++;
    }
    else
    {
        specialCharacter++;
    }
}

if(upperCount > 0 && lowerCount>0 && numberCount>0 && specialCharacter > 0)
{
    Console.WriteLine("Password is Strong");
}
else
{
    Console.WriteLine("Password is Weak");
}