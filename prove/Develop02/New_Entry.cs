class New_Entry
{
    public List<string> entries = new List<string>();

    public void DisplayEntries()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }
}