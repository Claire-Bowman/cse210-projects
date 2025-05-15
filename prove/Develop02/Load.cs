class Load
{
    public List<string> ReadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            var loadedEntries = File.ReadAllLines(filename).ToList();
            Console.WriteLine("Entries loaded successfully.");
            return loadedEntries;
        }
        else
        {
            Console.WriteLine("File not found.");
            return new List<string>();
        }
    }
}