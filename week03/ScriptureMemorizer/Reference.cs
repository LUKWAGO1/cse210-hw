public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // -1 indicates no end verse (single verse reference)
    }

    // Constructor for range of verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Method to get the display text
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            // Single verse reference
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Range of verses
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
