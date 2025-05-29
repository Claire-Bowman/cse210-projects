using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}