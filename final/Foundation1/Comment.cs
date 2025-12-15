public class Comment
{
    public string _text;
    public string _commenter;

    public Comment()
    {
    }

    public string DisplayComment()
    {
        return $" - From: {_commenter}\n   • '{_text}'"; 
    }
}