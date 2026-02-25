Console.Write("Enter your Salary : ");
double salary;
bool x =double.TryParse(Console.ReadLine(), out salary);

if (salary > 50000){
    double tax = 20;
    double taxAmount = salary * (tax / 100);
    double balanceAmount = salary - taxAmount;
    Console.WriteLine($"Your Salay is Rs.{salary} \nFor that Tax is 20% means Rs.{taxAmount} \nBalance Salary is {balanceAmount}"); 
}
else if (salary > 30000){
    double tax = 10;
    double taxAmount = salary * (tax / 100);
    double balanceAmount = salary - taxAmount;
    Console.WriteLine($"Your Salay is Rs.{salary} \nFor that Tax is 10% means Rs.{taxAmount} \nBalance Salary is {balanceAmount}"); 
}
else{
    Console.WriteLine($"Your Salay is Rs.{salary} \nFor that Tax is 0%(No Tax) \nBalance Salary is {salary}");
}