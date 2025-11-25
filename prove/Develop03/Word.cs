public class Word
{
    private string _singleWord;
    private bool _isHidden;

    public Word(string word)
    {
        _singleWord = word;
    }
    public void Hide()
    {
        foreach (char L in _singleWord){
            _singleWord = _singleWord.Replace(L , '_');
        }
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        return _singleWord;
    }
}