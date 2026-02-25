Console.WriteLine("Enter a Text inside File : ");
string fileText = Console.ReadLine();
Console.WriteLine("Enter a Name of a File(with file type. ex: .txt ) : ");
string fileName = Console.ReadLine();

try
{
    if(!string.IsNullOrWhiteSpace(fileText) && !string.IsNullOrWhiteSpace(fileName))
    {
        
        File.WriteAllText(fileName,fileText);
        Console.WriteLine("Saved Successful");
    }
    
    string readFile = File.ReadAllText(fileName);
    Console.WriteLine("Reading from file: \n" + readFile);

}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}


