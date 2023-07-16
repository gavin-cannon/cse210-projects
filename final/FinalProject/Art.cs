public abstract class Art
{
    protected string _title;
    protected string _artist;
    protected int _year;

    public virtual string ToString()
    {
        return $"{_title} \nCreated by: {_artist}. \nDated as: {_year}.";
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetArtist()
    {
        return _artist;
    }
    public int GetYear()
    {
        return _year;
    }
    public Art() { }
    public Art(string title, string artist, int year)
    {
        _title = title;
        _artist = artist;
        _year = year;
    }
}