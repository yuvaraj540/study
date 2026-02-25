Console.WriteLine("Enter a Sentence : ");
string? character = Console.ReadLine();
if (string.IsNullOrWhiteSpace(character))
{
     Console.WriteLine("Invalid Input....");
    return;
}

string[] words = character.ToLower().Split(" ");
Dictionary<string,int> wordDict = new();


    foreach(string i in words)
    {

        if (wordDict.TryGetValue(i,out int val))
        {
            wordDict[i] = val + 1;
        }
        else
        {
            wordDict[i] = 1;
        }        
    }

    foreach(var i in wordDict)
    {
        Console.WriteLine($"{i.Key} : {i.Value}");
    }





