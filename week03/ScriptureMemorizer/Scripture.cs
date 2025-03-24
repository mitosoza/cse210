using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        int remainingWords = GetRemainingWordsCount();
        int count = 0;

        if (numberToHide > remainingWords)
        {
            numberToHide = remainingWords;
        }

        while (count < numberToHide && _words.Count > 0)
        {
            int index = randomNumber.Next(_words.Count);
            Word wordToHide = _words[index];

            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
                count++;
            }
        }
    }

    public int GetRemainingWordsCount()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetScriptureString()
    {
        string scriptureString = _reference.GetReferenceString() + " ";

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                foreach (char c in word.GetWordString())
                {
                    if (c == ',' || c == '.')
                    {
                        scriptureString += c;
                    } else
                    {
                        scriptureString += "_";
                    }
                }
                scriptureString += " ";
            }
            else
            {
                scriptureString += word.GetWordString() + " ";
            }
        }

        return scriptureString;
    }
}