// //count digit
// Console.WriteLine("Enter your Number:");

// if (long.TryParse(Console.ReadLine(), out long y))
// {
//     long count = 0;
//     while(y > 0){
//         long lastDigit = y % 10;
//         count++;
//         y = y / 10;
//     }
//     Console.WriteLine(count);
// }
// else
// {
//     Console.WriteLine("Invalid input!");
// }



// //Number Reverse
// Console.WriteLine("Enter a Number : ");
// if(int.TryParse(Console.ReadLine(), out int num))
// {
//     int flag = 0;
//     if(num < 0)
//     {
//         num = int.Abs(num);
//         flag = 2;
//     }

//     int reverse = 0;
//     while(num > 0)
//     {
//         int lastDigit = num % 10;
//         reverse = (reverse * 10) + lastDigit;
//         num /= 10; 
//     }

//     if(flag > 0)
//     {
//         reverse = reverse * -1;
//     }

//     Console.WriteLine($"Reverse number is {reverse}");
// }
// else
// {
//     Console.WriteLine("Invalid input!");
// }




//Armstrong Number
using System.Globalization;

Console.WriteLine("Enter a Number : ");
if(int.TryParse(Console.ReadLine(), out int num))
{
    double sum = 0; 
    double count = 0;

    int nums = num;
    while(nums > 0){
        count += 1;
        nums = nums / 10;
    }    



    int numss = num;
    while(numss > 0)
    {
        double lastDigit = numss % 10;
        sum = Math.Pow(lastDigit,count) + sum;
        numss /= 10; 
    }

    if(sum == num)
    {
        Console.WriteLine("This number is Armstrong");
    }
    else
    {
        Console.WriteLine("This number is not Armstrong");
    }
}
else
{
    Console.WriteLine("Invalid input!");
}