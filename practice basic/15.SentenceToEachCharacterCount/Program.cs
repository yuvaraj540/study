Console.WriteLine("Enter a Sentence : ");
string character = Console.ReadLine().Replace(" ","").ToLower();
Dictionary<char,int> wordDict = new();

if (!string.IsNullOrWhiteSpace(character))
{
    foreach(char i in character)
    {

        if (wordDict.ContainsKey(i))
        {
            wordDict[i]++;
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
}
else
{
    Console.WriteLine("Invalid Input....");
    return;
}




