using System.Runtime.CompilerServices;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Numer of comments: {_comments.Count}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._author} says: {comment._text, 20:c}");
        }
        Console.WriteLine("\n");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}