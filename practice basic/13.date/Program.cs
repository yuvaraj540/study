Console.WriteLine("Enter a Starting date (yyyy-MM-dd) : ");
bool input1 = DateTime.TryParse(Console.ReadLine(), out DateTime  date1);
Console.WriteLine("Enter a Ending date (yyyy-MM-dd) : ");
bool input2 = DateTime.TryParse(Console.ReadLine(), out DateTime  date2);
 
// DateTime date1 = new DateTime(2026, 02, 01);
// DateTime date2 = new DateTime(2026, 02, 10);

if (input1 && input2)
{
    int TotalDays = 0;
    int WorkingDays = 0;
    while (date2 > date1)
    {   
        date1 = date1.AddDays(1);

        TotalDays++;

        if(date1.DayOfWeek != DayOfWeek.Saturday && date1.DayOfWeek != DayOfWeek.Sunday)
        {
            WorkingDays++;    
        }

        
    }
    Console.WriteLine($"Total Days : {TotalDays}");
    Console.WriteLine($"Working Days : {WorkingDays}");

}
else
{
    Console.WriteLine("Invalid Input....");
    return;
}
