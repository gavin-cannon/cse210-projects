public class Movie : Art
{
    private string _genre;
    private float _rating;

    public override string ToString()
    {
        return $"{_title} \nGenre:{_genre} movie. \nDirected by: {_artist}. \nReleased in {_year}. \nMy rating: {_rating}";
    }
    public Movie() { }
    public Movie(string title, string artist, int year, float rating, string genre)
    {
        _title = title;
        _artist = artist;
        _year = year;
        _rating = rating;
        _genre = genre;
    }
}