public class Video
{
    public string _title;
    public string _creator;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
    }
    
    public void AddComment(string text, string commenter)
    {
        Comment comment = new Comment();
        comment._text = text;
        comment._commenter = commenter;
        _comments.Add(comment);
    }
    public int GetTotalComments()
    {
        return _comments.Count;
    }
}