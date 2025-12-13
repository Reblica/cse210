public class Video
{
    private string _title;
    private string _creator;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetCreator()
    {
        return _creator;
    }
    public int GetLength()
    {
        return _length;
    }
    public void AddComment(string text, string commenter)
    {
        Comment comment = new Comment(text, commenter);
        _comments.Add(comment);
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.Write(" - ");
            Console.WriteLine($"From: {comment.GetCommenter()}\n   • '{comment.GetText()}'"); 
        }
    }
    public int GetTotalComments()
    {
        return _comments.Count;
    }
}