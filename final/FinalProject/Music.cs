public class Music : Art
{
    private string _musicalKey;

    public override string ToString()
    {
        return $"{_title} is piece in the key of {_musicalKey}. \nComposed by: {_artist}. \nFinished in {_year}.";
    }
    public Music(string title, string artist, int year, string key)
    {
        _title = title;
        _artist = artist;
        _year = year;
        _musicalKey = key;
    }
}