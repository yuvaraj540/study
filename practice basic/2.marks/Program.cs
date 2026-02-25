int[] a = new int[5];

Console.WriteLine("Enter 5 Subject Marks : ");
int marks = 0;

for(int i = 0; i < 5; i++){
    int x = int.Parse(Console.ReadLine());
    marks += x;
}

Console.WriteLine($"Total Marks : {marks}");
int average = marks/5;
Console.WriteLine($"Average is {average}");

switch (average){
    case >= 90:
        Console.WriteLine("Grade : A");
        break;
    case >= 75:
        Console.WriteLine("Grade : B");
        break;
    case >= 50:
        Console.WriteLine("Grade : C");
        break;
    default:
        Console.WriteLine("Fail");
        break;
};

