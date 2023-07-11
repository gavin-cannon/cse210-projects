public class Painting : Art
{
    private string _artMovement;

    public override string ToString()
    {
        return $"{_title} \nArt Movement:{_artMovement} movement. \nPainted by: {_artist}. \nDated as {_year}.";
    }
    public Painting(string title, string artist, int year, string movement)
    {
        _title = title;
        _artist = artist;
        _year = year;
        _artMovement = movement;
    }
}