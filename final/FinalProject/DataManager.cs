public class DataManager
{
    private List<Art> _artPieces = new List<Art>();
    public List<Art> GetArt()
    {
        return _artPieces;
    }
    public void AddArt(Art art)
    {
        _artPieces.Add(art);
    }
    public DataManager() { }

    public void LoadArt()
    {
        string[] movieList = System.IO.File.ReadAllLines("movies.txt");
        foreach (string line in movieList)
        {
            string[] movie = line.Split(",");
            string movieTitle = movie[0];
            int year = Int32.Parse(movie[1]);
            string director = movie[2];
            float rating = float.Parse(movie[3]);
            string genre = movie[4];
            AddArt(new Movie(movieTitle, director, year, rating, genre));
        }
        string[] paintingList = System.IO.File.ReadAllLines("painting.txt");
        foreach (string line in paintingList)
        {
            string[] painting = line.Split(",");
            string paintingTitle = painting[0];
            int year = Int32.Parse(painting[2]);
            string artist = painting[1];
            string movement = painting[3];
            AddArt(new Painting(paintingTitle, artist, year, movement));
        }
        string[] musicList = System.IO.File.ReadAllLines("musics.txt");
        foreach (string line in musicList)
        {
            string[] music = line.Split(",");
            string musicTitle = music[0];
            int year = Int32.Parse(music[3]);
            string artist = music[2];
            string key = music[1];
            AddArt(new Music(musicTitle, artist, year, key));
        }
    }

    public int GetArtLength(){
        return _artPieces.Count;
    }

    public void SortListForward(){
        _artPieces.Sort((x, y) => y.GetYear().CompareTo(x.GetYear()));
    }
    public void SortListReverse(){
        _artPieces.Sort((x, y) => x.GetYear().CompareTo(y.GetYear()));
    }
    public string GetArtPieceString(int listNumber){
        return _artPieces[listNumber].ToString();
    }
    public string GetMovieString(int listNumber){
        if (_artPieces[listNumber] is Movie){
            return _artPieces[listNumber].ToString();
        }
        return "None";
    }
    public string GetPaintingString(int listNumber){
        if (_artPieces[listNumber] is Painting){
            return _artPieces[listNumber].ToString();
        }
        return "None";
    }
    public string GetMusicString(int listNumber){
        if (_artPieces[listNumber] is Music){
            return _artPieces[listNumber].ToString();
        }
        return "None";
    }
}