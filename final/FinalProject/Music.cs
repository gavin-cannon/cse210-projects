public class Music : Art
{
    private string _musicalKey;

    public override string ToString()
    {
        return $"{base.ToString()} \nKey: {_musicalKey}.";
    }
    public Music(string title, string artist, int year, string key) :base(title, artist, year)
    {
        _musicalKey = key;
    }
}