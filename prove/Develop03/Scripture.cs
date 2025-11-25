public class Scripture
{
    private bool _allHidden;
    private Reference references;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(string[][] scriptures)
    {
        int scripture = _random.Next(0, scriptures.Length);
        string reference = scriptures[scripture][0];
        string text = scriptures[scripture][1];

        char[] separators = { ' ', ':', '-'};
        string[] ofReference = reference.Split(separators);
        
        if (ofReference.Length == 3){
            string book = ofReference[0];
            int chapter = int.Parse(ofReference[1]);
            int verse = int.Parse(ofReference[2]);
            references = new Reference(book, chapter, verse);
        }
        else if (ofReference.Length == 4)
        {
            string book = ofReference[0];
            int chapter = int.Parse(ofReference[1]);
            int verse = int.Parse(ofReference[2]);
            int endVerse = int.Parse(ofReference[3]);
            references = new Reference(book, chapter, verse, endVerse);
        }

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
        }
    }

    public bool IsCompletelyHidden()
    {   
        int isAllHidden = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                isAllHidden++;
            }
        }
        if (isAllHidden == _words.Count)
        {
            Console.Beep();
            _allHidden = true;
        }
        return _allHidden;
    }

    public void HideWords()
    {
        int number = 0;
        for (int i = 0; i < 3; i++){
            if (number != _words.Count)
            {
                int randomNumber = _random.Next(0, _words.Count);
                Word word = _words[randomNumber];
                if (word.IsHidden() == false)
                {
                    word.Hide();
                    _words[randomNumber] = word;
                }
                else if (word.IsHidden() == true)
                {
                    foreach (Word _word in _words)
                    {
                        if (_word.IsHidden() == true)
                        {
                            number++;
                        }
                    }
                    if (number == _words.Count)
                    {
                        i = 4;
                    }
                    else
                    {
                        i--;
                        number = 0;
                    }
                }
            }
        }
    }

    public void GetRenderedText()
    {
        Console.Clear();

        string book = references.GetBook();
        int chapter = references.GetChapter();
        int verse = references.GetVerse();
        int endVerse = references.GetEndVerse();

        if (endVerse == 0)
        {
            Console.Write($"{book} {chapter}: {verse} ");
        }
        else
        {
            Console.Write($"{book} {chapter}: {verse}-{endVerse} ");
        }
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetRenderedText()} ");
        }
        Console.WriteLine();
        Console.WriteLine("Press 'enter' key to continue or 'quit' to exit:");
    }

}