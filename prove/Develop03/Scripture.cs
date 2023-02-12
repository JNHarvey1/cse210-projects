using System;

class Scripture
{
    // Create the list of verses before the constructor is called.
    private List<Verse> _verses = new List<Verse>();
    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }

    public bool HideWords(int count)
    {
        return true;
    }


    public bool IsAllHidden()
    {   
        int length = _verses.Count();
        for (int i = 1; i < length; i++)
        if (_verses[i] != _verses[0])
        {
            return false;
        }
        return true;
    } 
}