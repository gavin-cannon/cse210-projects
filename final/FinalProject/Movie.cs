public class Movie : Art
{
    private string _genre;
    private float _rating;

    public override string ToString()
    {
        return $"{base.ToString()}\nGenre: {_genre} movie. \nMy rating: {_rating}";
    }
    public Movie() { }
    public Movie(string title, string artist, int year, float rating, string genre) :base(title, artist, year)
    {
        _rating = rating;
        _genre = genre;
    }
}