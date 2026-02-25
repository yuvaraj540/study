bool IsOnlineFlag = true;
double balance = 10000;
List<string> transactionHistory = new();


while (IsOnlineFlag)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Hello Yuvarajan... \nYour Account 1012*****756 is Online");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Choose Your Service : ");
    Console.WriteLine("1. Balance Check \n2. Deposit \n3. Withdraw \n4. View Transaction History \n5. Exit");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Enter your Choice : ");
    bool choices = int.TryParse(Console.ReadLine(), out int choice);
    Console.WriteLine("----------------------------------------------------------------");
    
    if (!choices)
    {
        Console.WriteLine("Invalid Input");
        continue;
    }


    if(choice > 5 || choice < 1)
    {
        Console.WriteLine("Invalid Input");
        continue;
    }

    switch (choice){
        case 1:
            Console.WriteLine("================================================================");
            Console.WriteLine($"||                 Your Balance is {balance}                  ||");
            Console.WriteLine("================================================================");
            break;

        case 2:
            Console.WriteLine("Enter a Deposit Amount :");

            if(double.TryParse(Console.ReadLine(), out double depositAmount)){
                balance += depositAmount;
                transactionHistory.Add($"|| Deposited    + Rs.{depositAmount}    {DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}||");
                Console.WriteLine("================================================================");
                Console.WriteLine($"||  Deposit Successful!!! Deposit Amount is {depositAmount}  ||");
                Console.WriteLine($"||   After Deposit,Your Available Balance is {balance}       ||");
                Console.WriteLine("================================================================");
                break;
            }
            else
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("================================================================");
                continue;
            }
        case 3:
            Console.WriteLine("Enter a Withdraw Amount :");
            
            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
            {
                if (balance < withdrawAmount)
                {
                    Console.WriteLine("================================================================");
                    Console.WriteLine("Insufficient Balance.Try Again...");
                    Console.WriteLine("================================================================");
                    continue;
                }
                balance -= withdrawAmount;
                transactionHistory.Add($"|| WithDrawel   - Rs.{withdrawAmount}    {DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}||");
                Console.WriteLine("================================================================");
                Console.WriteLine($"||Withdraw Successful!!!.Withdraw Amount is {withdrawAmount}||");
                Console.WriteLine($"||    After Withdraw,Your Available Balance is {balance}    ||");
                Console.WriteLine("================================================================");
                break;
            }
            else
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("================================================================");
                continue;
            }

        case 4:
            if(transactionHistory.Count() > 0)
            {
                Console.WriteLine("================================================================");
                foreach (string i in transactionHistory)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("================================================================");
            }
            else
            {
                Console.WriteLine("================================================================");
                Console.WriteLine($"||               No Transaction History...                   ||");
                Console.WriteLine("================================================================");
            }
            break;
        default:
            Console.WriteLine("================================================================");
            Console.WriteLine($"||       Account is offline.Cannot do any service.           ||");
            Console.WriteLine("================================================================");
            IsOnlineFlag = false;
            break;
    }
}
