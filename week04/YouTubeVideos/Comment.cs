public class Comment
{
    public string _text;
    public string _author;

    public string Display()
    {
        return $"{_author}: {_text}";
    }
}