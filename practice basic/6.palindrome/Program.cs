string? a = Console.ReadLine();
string b = a[0].ToString();
for(int i=1; i < a.Length; i++){

    b = a[i] + b; 

}

Console.WriteLine(b);

if(a == b){
    Console.WriteLine("This is palindrome");
}
else{
    Console.WriteLine("This is not palindrome");
}
