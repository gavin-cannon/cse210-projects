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
        string[] artList = System.IO.File.ReadAllLines("art.txt");
        foreach (string line in artList)
        {
            string[] art = line.Split(",");
            string artType = art[0];
            if (artType == "Movie"){
                string movieTitle = art[1];
                int year = Int32.Parse(art[2]);
                string director = art[3];
                float rating = float.Parse(art[4]);
                string genre = art[5];
                AddArt(new Movie(movieTitle, director, year, rating, genre));
            }
            else if (artType == "Painting"){
                string paintingTitle = art[1];
                int year = Int32.Parse(art[3]);
                string artist = art[2];
                string movement = art[4];
                AddArt(new Painting(paintingTitle, artist, year, movement));
            }
            else if (artType == "Music"){
                string musicTitle = art[1];
                int year = Int32.Parse(art[4]);
                string artist = art[3];
                string key = art[2];
                AddArt(new Music(musicTitle, artist, year, key));
            }
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