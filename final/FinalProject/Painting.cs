public class Painting : Art
{
    private string _artMovement;

    public override string ToString()
    {
        return $"{base.ToString()} \nArt Movement: {_artMovement} movement.";
    }
    public Painting(string title, string artist, int year, string movement) : base(title, artist, year)
    {
        _artMovement = movement;
    }
}