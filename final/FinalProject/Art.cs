public abstract class Art
{
    protected string _title;
    protected string _artist;
    protected int _year;

    public abstract string ToString();
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
}