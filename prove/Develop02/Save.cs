class Save
{
    public void SaveToFile(List<string> entries)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        File.WriteAllLines(filename, entries);
        Console.WriteLine("Entries saved successfully.");
    }
}