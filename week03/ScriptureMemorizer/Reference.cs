using System;

class Reference
{
    private string _bookName;
    private int _chapterNumber;
    private int _startVerse;
    private int _endVerse;


    public Reference(string bookName, int chapterNumber, int startVerse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startVerse = startVerse;
        _endVerse = 0;
    }

    public Reference(string bookName, int chapterNumber, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetBookName()
    {
        return _bookName;
    }

    public void SetBookName(string bookName)
    {
        _bookName = bookName;
    }

    public int GetChapterNumber()
    {
        return _chapterNumber;
    }

    public void SetChapterNumber(int chapterNumber)
    {
        _chapterNumber = chapterNumber;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetReferenceString()
    {
        if (_endVerse == 0)
        {
            return $"{_bookName} {_chapterNumber}:{_startVerse}";
        }
        else
        {
            return $"{_bookName} {_chapterNumber}:{_startVerse}-{_endVerse}";
        }
    }
}