public class Comment
{
    private string _text;
    private string _commenter;

    public Comment(string text, string commenter)
    {
        _text = text;
        _commenter = commenter;
    }

    public string GetText()
    {
        return _text;
    }
    public string GetCommenter()
    {
        return _commenter;
    }
}