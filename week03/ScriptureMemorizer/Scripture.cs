public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < count)
        {
            int index = random.Next(_words.Count);

            if (_words[index].IsHidden())
            {
                continue;
            }
            else
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        return string.Join(' ', _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(words => words.IsHidden());
    }
}