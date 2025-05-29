using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string referenceStr, string text)
    {
        _reference = ParseReference(referenceStr);
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    private Reference ParseReference(string refStr)
    {
        // Example input: "Proverbs 3:5-6" or "John 3:16"
        var parts = refStr.Split(' ');
        var book = parts[0];
        var chapterAndVerse = parts[1].Split(':');
        var chapter = int.Parse(chapterAndVerse[0]);

        var verseParts = chapterAndVerse[1].Split('-');
        var verse = int.Parse(verseParts[0]);
        int? endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : (int?)null;

        return new Reference(book, chapter, verse, endVerse);
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
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

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public Reference GetReference()
    {
        return _reference;
    }
}