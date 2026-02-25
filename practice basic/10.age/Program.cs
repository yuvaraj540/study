Console.WriteLine("Enter a Date of Birth (yyyy-MM-dd): ");
string? dob = Console.ReadLine();
if (string.IsNullOrWhiteSpace(dob))
{
    Console.WriteLine("Invalid input...");
    return;
}
string[] dobArr = dob.Split("-");

int birthYear = int.Parse(dobArr[0]);
int currentYear = DateTime.Now.Year;
int ageInYear = currentYear - birthYear;
Console.WriteLine($"Age in Years : {ageInYear}");
Console.WriteLine($"Age in Years : {ageInYear * 365}");





// Console.WriteLine("Enter Date of Birth (yyyy-MM-dd): ");
// string? dobInput = Console.ReadLine();

// if (!DateTime.TryParse(dobInput, out DateTime dob))
// {
//     Console.WriteLine("Invalid input...");
//     return;
// }

// DateTime today = DateTime.Now;

// // Age in years
// int ageYears = today.Year - dob.Year;
// if (dob.Date > today.AddYears(-ageYears)) ageYears--;

// // Total days lived
// TimeSpan daysLived = today - dob;

// Console.WriteLine($"Age in Years: {ageYears}");
// Console.WriteLine($"Total Days Lived: {daysLived.Days}");
